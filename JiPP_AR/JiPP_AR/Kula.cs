using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_AR
{
    public class Kula
    {
        // Zmienne, pola obiektu
        public Brush Pedzel;
        public Size Rozmiar;
        public Point Pozycja;
        public int Predkosc;

        public Point kierunekLotu;

        // Konstruktor
        public Kula(Point pozycja, int predkosc = 3)
        {
            Pedzel = new SolidBrush(Color.Red);
            Rozmiar = new Size(25, 25);
            Pozycja = pozycja;
            Predkosc = predkosc;

            kierunekLotu = new Point(Predkosc, Predkosc);
        }

        // Funkcja rysowania
        public void Rysuj(Graphics g)
        {
            g.FillEllipse(Pedzel, new Rectangle(Pozycja, Rozmiar));
            using (Font font = new Font("Times New Roman", 22, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                g.DrawString(kierunekLotu.X + ":" + kierunekLotu.Y, font, new SolidBrush(Color.DarkGray), 15, 200);
            }
        }

        // Zmiana pozycji wzgledem kierunku lotu
        public void Lot()
        {
            Pozycja.X += kierunekLotu.X;
            Pozycja.Y += kierunekLotu.Y;
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

        // W przypadku kolizji odbij obiekt = zmien kierunek lotu osi Y
        public void Kolizja(Gracz gracz)
        {
            if (left >= gracz.left && right <= gracz.right)
            {
                if (bottom >= gracz.top && top <= gracz.bottom)
                    kierunekLotu.Y = -kierunekLotu.Y;
            }
        }

        // W przypadku scian bocznych odbij obiekt = zmien kierunek osi X
        public void Sciany()
        {
            if (left < 25)
                kierunekLotu.X = -kierunekLotu.X;
            else if (right > Game.Szerokosc - 25)
                kierunekLotu.X = -kierunekLotu.X;
        }
    }
}