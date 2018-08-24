using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_MK
{
    // Publiczna klasa Uczen
    public class Uczen
    {
        // Publiczne wlasciwosci
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Plec Plec { get; set; }
        public Klasa Klasa { get; set; }

        public int IloscDniSzkoly { get; set; }
        public int OdbyteZajecia { get; set; }
        public int Ucieczki { get; set; }
        public int Frekwencja
        {
            get
            {
                // Sprawdzamy zeby nie dzielic przez 0
                if (OdbyteZajecia == 0)
                    return 0;
                
                // Zwracamy procent frekwencji na podstawie ucieczek i odbytych zajec
                return (int)(((float)OdbyteZajecia / (float)IloscDniSzkoly) * 100.0f);
            }
        }

        public bool CzyDzisUciekl;

        // Konstruktor klasy z parametrami wchodzacymi
        public Uczen(string imie, string nazwisko, Plec plec, Klasa klasa)
        {
            // Przypisanie parametrow do wlasciwosci obiektu
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            Klasa = klasa;
        }

        /// <summary>
        /// Nadpisanie domyslnej funkcji ToString aby bylo widac ladna nazwe obiektu w kolekcjach.
        /// </summary>
        /// <returns>Zwraca nazwe obiektu - Imie oraz Nazwisko</returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }

        // Funkcja ustawiajaca odpowiednie zmienne jezeli obiekt Ucznia wagaruje
        public void DzisWagary()
        {
            CzyDzisUciekl = true;
            IloscDniSzkoly++;
            Ucieczki++;

            pen = new Pen(Szkola.KolorFrekwencji(Frekwencja));
        }

        // Funkcja ustawiajaca odpowiednie zmienne jezeli obiekt Ucznia idzie do szkoly na lekcje
        public void DzisDoSzkoly()
        {
            CzyDzisUciekl = false;
            IloscDniSzkoly++;
            OdbyteZajecia++;

            pen = new Pen(Szkola.KolorFrekwencji(Frekwencja));
        }

        /// <summary>
        /// Zmienna do poruszania emocji ucznia
        /// </summary>
        public int X = 126;


        // Deklaracja dlugopisu
        public Pen pen = new Pen(Color.Blue);

        /// <summary>
        /// Funkcja rysujaca emocje tego obiektu na podstawie frekwencji
        /// </summary>
        /// <param name="g">Obiekt graficzny na ktorym bedzie cos rysowane.</param>
        /// <param name="panel">Panel w ktorym bedzie tworzona grafika, w celu skalowania</param>
        public void RysujEmocje(Graphics g, Panel panel)
        {
            // Deklaracja srodka panela
            int szerokosc = X;
            int wysokosc = panel.Size.Height / 2;

            // Rysowanie twarzy
            int sredniacaTwarzy = 80;
            g.DrawEllipse(pen, szerokosc - sredniacaTwarzy / 2, wysokosc - sredniacaTwarzy / 2, sredniacaTwarzy, sredniacaTwarzy);

            // Rysowanie oczu
            int sredniacaOczu = 10;
            g.DrawEllipse(pen, szerokosc - sredniacaOczu / 2 - 15, wysokosc - sredniacaOczu / 2 - 10, sredniacaOczu, sredniacaOczu);
            g.DrawEllipse(pen, szerokosc - sredniacaOczu / 2 + 15, wysokosc - sredniacaOczu / 2 - 10, sredniacaOczu, sredniacaOczu);

            // Rysowanie nosa
            g.DrawLine(pen, szerokosc, wysokosc - 10, szerokosc - 5, wysokosc + 10);
            g.DrawLine(pen, szerokosc - 5, wysokosc + 10, szerokosc + 5, wysokosc + 8);

            // Rysowanie ust
            g.DrawLine(pen, szerokosc - 20, wysokosc + 17, szerokosc + 20, wysokosc + 17);
            Rectangle rect = new Rectangle(szerokosc - 20, wysokosc + 10, 40, 15);
            g.DrawArc(pen, rect, 0, 180);
        }
    }
}