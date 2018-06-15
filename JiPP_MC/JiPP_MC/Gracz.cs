using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_MC
{
    public class Gracz
    {
        // pola, zmienne
        public Point Pozycja;
        public Size Wielkosc;
        public Brush Pedzel;

        public bool Shot = false;
        private float czas = 0.5f;

        // konstruktor
        public Gracz()
        {
            Wielkosc = new Size(20, 20);
            Pozycja.X = 20;
            Pozycja.Y = 400;
            Pedzel = Brushes.Gold;
        }

        // metoda rysowania obiektu gracza
        public void Rysuj(Graphics g)
        {
            g.FillEllipse(Pedzel, new Rectangle(Pozycja.X * Wielkosc.Width, Pozycja.Y, Wielkosc.Width, Wielkosc.Height));
        }

        // metoda tworzaca pociski jezeli obiekt atakuje
        public void Strzal(bool wgore = true)
        {
            if (!Shot)
                return;

            // strzal co jakis "czas"
            if(czas > 0)
            {
                czas -= 0.05f;
                return;
            }
            czas = 0.5f;

            // dodanie nowego pocisku do statycznej kolekcji w klasie Form1
            Form1.Strzaly.Add(new Strzal(Pozycja, wgore));
        }
    }
}