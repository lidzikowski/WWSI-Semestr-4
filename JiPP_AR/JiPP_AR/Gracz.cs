using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_AR
{
    // Pozycje graczy jako slownik
    public enum PozycjaGracza
    {
        Gora,
        Dol
    }
    
    // Deklaracja typu delegata do dziennika
    public delegate void DziennikHandler(string wiadomosc);

    // Klasa Gracz
    public class Gracz
    {
        // Pola, zmienne, wlasciwosci obiektu
        public string Imie;

        public Brush Pedzel;
        public Size Rozmiar;
        public Point Pozycja;

        public bool ruchLewo = false;
        public bool RuchLewo
        {
            get { return ruchLewo; }
            set
            {
                ruchLewo = value;
                if (ruchLewo)
                    Dziennik(Imie + " przemieszcza sie w lewo!"); // wywolanie zdarzenia
            }
        }
        public bool ruchPrawo = false;
        public bool RuchPrawo
        {
            get { return ruchPrawo; }
            set
            {
                ruchPrawo = value;
                if (ruchPrawo)
                    Dziennik(Imie + " przemieszcza sie w prawo!"); // wywolanie zdarzenia
            }
        }

        public int SzybkoscRuchu = 15;

        private bool gotowy = false;
        public bool Gotowy
        {
            get { return gotowy; }
            set
            {
                gotowy = value;
                if (gotowy)
                    Dziennik(Imie + " jest gotowy do gry!"); // wywolanie zdarzenia
                else
                    Dziennik("Gracz " + Imie + " wyszedl z gry!"); // wywolanie zdarzenia
            }
        }
        // zdarzenie obiektu
        public event DziennikHandler Dziennik;

        private int wynik = 0;
        public int Wynik
        {
            get { return wynik; }
            set
            {
                wynik = value;
                if (value != 0)
                    Dziennik(Imie + " zdobyl punkt."); // wywolanie zdarzenia
            }
        }

        // Konstruktor
        public Gracz(IForm gracz)
        {
            Rozmiar = new Size(100, 20);

            Dziennik += gracz.Wiadomosc; // Przypisanie metody do zdarzenia w obiekcie
        }

        // Metoda rysowania
        public void Rysuj(Graphics g)
        {
            // Prostokat
            g.FillRectangle(Pedzel, new Rectangle(Pozycja, Rozmiar));

            // Wynik
            using (Font font = new Font("Times New Roman", 22, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                g.DrawString(Imie + ": " + Wynik, font, new SolidBrush(Color.DarkGray), 15, Pozycja.Y);
            }
        }

        // Ruch gracza
        public void Ruch(Game game)
        {
            if (RuchLewo)
            {
                int pozycja = Pozycja.X - SzybkoscRuchu;
                if (pozycja > 5)
                    Pozycja.X = pozycja;
            }
            else if (RuchPrawo)
            {
                int pozycja = Pozycja.X + SzybkoscRuchu;
                if (pozycja < game.Size.Width - Rozmiar.Width - 20)
                    Pozycja.X = pozycja;
            }
        }

        #region Wlasciwosci obiektu
        public int top
        {
            get { return Pozycja.Y; }
        }
        public int bottom
        {
            get { return Pozycja.Y + Rozmiar.Height; }
        }
        public int left
        {
            get { return Pozycja.X; }
        }
        public int right
        {
            get { return Pozycja.X + Rozmiar.Width; }
        }
        public int X
        {
            get { return top + (Rozmiar.Height / 2); }
        }
        public int Y
        {
            get { return left + (Rozmiar.Width / 2); }
        }
        #endregion
    }
}