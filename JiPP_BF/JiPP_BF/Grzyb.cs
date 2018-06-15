using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_BF
{
    public class Grzyb
    {
        // Zmienne, pola:
        public Bitmap GrzybBitmap;
        public Point Pozycja;

        // Konstruktor z parametrem
        public Grzyb(Point pozycja, IMario mario)
        {
            Pozycja = pozycja; // przypisanie parametru do zmiennej obiektu
            mario.GrzybobranieHandler += Zniszcz; // Przypisanie metody do eventu

            // Zadanie asynchroniczne
            var t = Task.Run(async () =>
            {
                GrzybBitmap = Properties.Resources.mushroom;
            });
            t.Wait(); // Zaczekanie na zakonczenie zadania
        }

        // Metoda rysowania 
        public void Rysuj(Graphics g)
        {
            var matrix = g.Transform; // Zapis stanu transformu
            g.TranslateTransform(Pozycja.X, Pozycja.Y); // Zmiana polozenia transformu
            g.DrawImage(GrzybBitmap, 0, 0); // Wyswietlenie bitmapy
            g.Transform = matrix; // Przywrocenie transformu
        }

        // Wykrywanie kolizji
        public bool Kolizja(Mario mario)
        {
            // centralny punkt grzyba
            Point grzybPoint = SrodekObiektu(Pozycja, GrzybBitmap);
            // centralny punkt obiektu mario - gracza
            Point marioPoint = SrodekObiektu(mario.Pozycja, mario.MarioBitmap);

            // jezeli mario jest w okolicy grzyba zwroc prawde
            if ((int)Dystans(grzybPoint, marioPoint) < mario.MarioBitmap.Width)
                return true;
            // jezeli warunek wyzej sie nie spelni zwroc falsz - nie ma gracza w okolicy = kolizja nie nastapila
            return false;
        }

        // Prywatna metoda do eventu
        private void Zniszcz(IMario mario)
        {
            mario.GrzybobranieHandler -= Zniszcz; // Odpinanie metody od zdarzenia
        }

        #region Funkcje matematyczne
        private float Dystans(Point a, Point b)
        {
            return (float)Math.Sqrt((Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        }

        private Point SrodekObiektu(Point pozycja, Bitmap bitmapa)
        {
            return new Point(pozycja.X + bitmapa.Width / 2, pozycja.Y + bitmapa.Height / 2);
        }
        #endregion
    }
}