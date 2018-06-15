using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_MC
{
    public class Strzal
    {
        // zmienne, pola
        public Point Pozycja;
        public Size Wielkosc;
        public Brush Pedzel;

        private bool wGore;

        // konstruktor
        public Strzal(Point pozycja, bool wgore = true)
        {
            Pozycja = pozycja;
            Wielkosc = new Size(5, 5);
            Pedzel = Brushes.Red;
            wGore = wgore;
        }

        // metoda rysowania obiektu
        public void Rysuj(Graphics g, bool gracz = true)
        {
            // jezeli gracz == true to X = pozycja.x * 20, jezeli gracz == false to X = pozycja.x * wielkosc.szerokosc
            int x = gracz ? Pozycja.X * 20 : Pozycja.X * Wielkosc.Width;
            // rysowanie
            g.FillRectangle(Pedzel, new Rectangle(x, Pozycja.Y, Wielkosc.Width, Wielkosc.Height));
        }

        // metoda ruchu pocisku
        public bool Ruch()
        {
            if (wGore) // w gore
                Pozycja.Y -= 10;
            else // w dol
                Pozycja.Y += 10;

            // jezeli pocisk wyleci poza ekran, zwroc true
            if (Pozycja.Y < 0 || Pozycja.Y > 450)
                return true;
            return false; // zwroc falsz jezeli warunek wyzej sie nie spelni
        }
    }
}