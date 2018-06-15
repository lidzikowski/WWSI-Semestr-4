using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_SS
{
    // Dziennik z kierunkami ruchu
    public enum Kierunki
    {
        Gora,
        Dol,
        Lewo,
        Prawo
    }

    public delegate void ZmianaKoloru(Random rnd); // deklaracja typu delegata

    // klasa
    public class Snake
    {
        // zmienne, pola, wlasciwosci
        public Point Pozycja;
        public Size Rozmiar;

        private int punkty = 0;
        public int Punkty
        {
            get { return punkty; }
            set {
                punkty = value;
                Random rnd = new Random(); // stworzenie obiektu losowosci
                ZmianaKoloruHandler(rnd); // wywolanie zdarzenia(eventu) z przekazaniem mu obiektu losowosci
            }
        }

        public Kierunki Kierunek;
        List<Punkt> Cialo; // kolekcja z cialem weza

        Brush kolorGlowy = Brushes.OrangeRed; // kolor jego glowy

        public event ZmianaKoloru ZmianaKoloruHandler; // event

        // konstruktor
        public Snake()
        {
            Pozycja = new Point(25, 14);
            Rozmiar = new Size(16, 16);
            Kierunek = Kierunki.Prawo;
            Cialo = new List<Punkt>();
            Cialo.Add(new Punkt() { X = Pozycja.X, Y = Pozycja.Y }); // dodanie 1 elementu dziala = glowa
        }

        // metoda rysowania calego weza
        public void Rysuj(Graphics g)
        {
            for (int i = 0; i < Cialo.Count; i++)
            {
                // jezeli i jest rowne 0, ustaw kolor glowy, jezeli nie ustaw kolor elementu
                Brush brush = i == 0 ? kolorGlowy : Cialo[i].Kolor;

                // wspolrzedne x i y elementu
                int x = Cialo[i].X * Rozmiar.Width;
                int y = Cialo[i].Y * Rozmiar.Height;

                // rysowanie kolorem, w pozycji oraz wielkosci
                g.FillEllipse(brush, new Rectangle(x, y, Rozmiar.Width, Rozmiar.Height));
            }
        }

        // metoda ruchu zwracajaca czy waz wyjdzie poza okno gry = koniec gry
        public bool Ruch(List<Punkt> jedzenie)
        {
            for (int i = Cialo.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    // sprawdzanie kierunku weza oraz zmiana jego pozycji
                    if (Kierunek == Kierunki.Gora)
                        Cialo[i].Y--;
                    else if (Kierunek == Kierunki.Dol)
                        Cialo[i].Y++;
                    else if (Kierunek == Kierunki.Lewo)
                        Cialo[i].X--;
                    else if (Kierunek == Kierunki.Prawo)
                        Cialo[i].X++;

                    // wspolrzedne konca okna gry
                    int maxX = 800 / Rozmiar.Width;
                    int maxY = 450 / Rozmiar.Height;

                    // sprawdzanei czy waz wyszedl poza okno gry
                    if (Cialo[i].X < 0 || Cialo[i].X > maxX ||
                        Cialo[i].Y < 0 || Cialo[i].Y > maxY)
                    {
                        return true;
                    }

                    // sprawdzanie czy waz napotkal na swojej drodze jedzenie
                    foreach (Punkt jedz in jedzenie)
                    {
                        // jezeli spotkal:
                        if(jedz.X == Cialo[i].X && jedz.Y == Cialo[i].Y)
                        {
                            // stworz nowy element weza
                            Punkt p = new Punkt();
                            p.X = Cialo[i].X; // ustaw mu x
                            p.Y = Cialo[i].Y; // ustaw mu y
                            ZmianaKoloruHandler += p.ZmianaKoloru; // przypisanie metody zmiany koloru elementu weza do zdarzenia w wezu
                            Cialo.Add(p); // dodanie nowego elementu do kolekcji
                            Punkty++; // zwiekszenie punktu + uruchomienie eventu
                            jedzenie.Remove(jedz); // usuniecie "zjedzonego" jedzenia
                            break;
                        }
                    }
                }
                else
                {
                    // jezeli obecny elemeny to nie glowa, przypisz mu nowa pozycje jako pozycja poprzedniego elementu
                    Cialo[i].X = Cialo[i - 1].X;
                    Cialo[i].Y = Cialo[i - 1].Y;
                }
            }
            return false;
        }
    }
}