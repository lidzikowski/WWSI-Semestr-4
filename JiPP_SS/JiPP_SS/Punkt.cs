using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_SS
{
    public class Punkt
    {
        public int X;
        public int Y;
        public Brush Kolor;

        public Punkt()
        {
            X = 0;
            Y = 0;
            Kolor = Brushes.Red;
        }

        // Metoda ktora bedzie przypisana do zdarzenia w obiekcie Snake
        public void ZmianaKoloru(Random rnd)
        {
            // Zmiana koloru z kolekcji statycznej zdefiniowanej w klasie Form1
            Kolor = Form1.Kolory[rnd.Next(0, Form1.Kolory.Count - 1)];
        }
    }
}