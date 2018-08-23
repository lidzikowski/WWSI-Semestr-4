using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_LS
{
    // Deklaracja wlasnego typu delegata
    public delegate void Aktualizacja(Pracownik pracownik);

    // publiczna klasa Pracownik
    public class Pracownik
    {
        // publiczne wlasciwosci
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public double Wiek { get; set; }
        /// <summary>
        /// Publiczna wlasciwosc typu pracownika zwracana na podstawie wieku obiektu
        /// </summary>
        public TypPracownika Typ
        {
            get
            {
                if (Wiek > 40)
                    return TypPracownika.Senior;
                else if (Wiek > 30)
                    return TypPracownika.Middle;
                else if (Wiek > 20)
                    return TypPracownika.Junior;
                return TypPracownika.Starzysta;
            }
        }
        /// <summary>
        /// Publiczna wlasciwosc zwracajaca zarobki na podstawie typu pracownika
        /// </summary>
        public double Zarobki
        {
            get
            {
                switch (Typ)
                {
                    case TypPracownika.Starzysta:
                        return 2;
                    case TypPracownika.Junior:
                        return 5;
                    case TypPracownika.Middle:
                        return 10;
                    case TypPracownika.Senior:
                        return 20;
                }
                return 0;
            }
        }

        private double zarobionaGotowka = 0;
        public double ZarobionaGotowka
        {
            get { return zarobionaGotowka; }
        }

        // Deklaracja zdarzenia obiektu
        public event Aktualizacja OnAktualizacja;

        // Konstruktor z parametrami
        public Pracownik(string imie, string nazwisko, int wiek)
        {
            // Przypisanie wartosci z parametrow do wlasciwosci obiektu
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        // Funkcja majaca na celu przypiecia metody do zdarzenia
        public void PrzypnijZdarzenie(IPracownik zdarzenie)
        {
            OnAktualizacja += zdarzenie.Pracownik_OnAktualizacja;
        }
        // Funkcja majaca na celu odpiecia metody do zdarzenia
        public void OdepnijZdarzenie(IPracownik zdarzenie)
        {
            OnAktualizacja -= zdarzenie.Pracownik_OnAktualizacja;
        }

        /// <summary>
        /// Funkcja zwracajaca nazwe obiektu na podstawie jego wlasciwosci
        /// </summary>
        /// <returns>Imie oraz nazwisko obiektu</returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }

        // Granica rysowania
        int granica = 200;

        // Predkosc poruszania sie postaci
        int predkoscRuchu = 5;

        // Funkcja zycia obiektu, "zarabia pracujac"
        public void Pracuj()
        {
            // Zwiekszanie wlasciwosci/zmiennych obiektu
            zarobionaGotowka += Zarobki;
            Wiek += 0.1;

            // Wywolanie zdarzenia w metodzie pracy obiektu
            if (OnAktualizacja != null)
                OnAktualizacja(this);
        }

        /// <summary>
        /// Funkcja wykonujaca operacje ruchu obiektu
        /// </summary>
        public void Ruch()
        {
            if (Lewo)
            {
                // Jezeli X jest wieksze od ujemnej granicy, odejmujemy wartosc o jeden, w przeciwnym wypadku nie zmieniamy nic w pozycji X
                X = X > -granica ? X -= predkoscRuchu : X;
            }
            else if (Prawo)
            {
                // Jezeli X jest mniejsze od dodatniej granicy, dodajemy wartosc o jeden, w przeciwnym wypadku nie zmieniamy nic w pozycji X
                X = X < granica ? X += predkoscRuchu : X;
            }
        }

        // Zmienne do metody rysowania
        private int X = 0;

        // Publiczne wlasciwosci chodzenia w lewo lub prawo
        public bool Lewo { get; set; }
        public bool Prawo { get; set; }

        // Smienna z pedzlem do rysowania, dobor koloru do zarobionej gotowki:
        // zielony = zarobki wieksze od 1000
        // zolty = zarobki wieksze od 50
        // czerwony = zarobki mniejsze niz 500
        SolidBrush pedzel => new SolidBrush(zarobionaGotowka > 1000 ? Color.Green : zarobionaGotowka > 500 ? Color.Yellow : Color.Red);
        Pen dlugopis => new Pen(Color.Black);
        static Random random = new Random();

        // Funkcja rysujaca obiekt
        public void Rysuj(Graphics g)
        {
            // Rysowanie kola = glowy w kolorze zadowolenia
            g.FillEllipse(pedzel, new Rectangle(265 + X, 417 - 150, 50, 50));

            // Tablice z punktami i rysowanie elementu ciala
            Point[] tulow = {
                new Point(265 + X + 25, 417 - 150 + 50),
                new Point(265 + X + 25, 417 - 50 + 25)
            };
            g.DrawLines(dlugopis, tulow);

            // wskaznik samopoczucia na podstawie zarobionych pieniedzy
            int samopoczucie = zarobionaGotowka > 1000 ? 0 : zarobionaGotowka > 500 ? 1 : 3;

            // Stworzenie napisu o samopoczuciu
            string tekstSamopoczucia = samopoczucie == 0 ? "Zadowolony, spokojny pracownik." : samopoczucie == 1 ? "Lekko niespokojny pracownik." : "Wkurzony na brak gotowki.";

            // Rysowanie napisu
            g.DrawString(tekstSamopoczucia, new Font("Arial", 16), new SolidBrush(Color.Blue), 10, 10);

            // Punkty lewej reki
            Point[] rekaLewa = {
                new Point(290 + X, 337),
                new Point(240 + X, 367 - random.Next(0, samopoczucie * 10))
            };
            // Rysowanie lewej reki
            g.DrawLines(dlugopis, rekaLewa);

            // Punkty prawej reki
            Point[] rekaPrawa = {
                new Point(290 + X, 337),
                new Point(340 + X, 367 - random.Next(0, samopoczucie * 10))
            };
            // Rysowanie prawej reki
            g.DrawLines(dlugopis, rekaPrawa);

            // Punkty lewej nogi
            Point[] nogaLewa = {
                new Point(290 + X, 392),
                new Point(260 + X - random.Next(0, samopoczucie * 10 / 2), 465)
            };
            // Rysowanie lewej nogi
            g.DrawLines(dlugopis, nogaLewa);

            // punkty prawej nogi
            Point[] nogaPrawa = {
                new Point(290 + X, 392),
                new Point(320 + X - random.Next(0, samopoczucie * 10 / 2), 465)
            };
            // Rysowanie prawej nogi
            g.DrawLines(dlugopis, nogaPrawa);
        }
    }
}