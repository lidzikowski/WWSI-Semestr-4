using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP_BF
{
    // Delegat
    public delegate void Grzybobranie(IMario mario);

    public class Mario : IMario
    {
        // Zmienne, pola, wlasciwosci publiczne/prywatne
        public Bitmap MarioBitmap;
        public Point Pozycja;

        public bool RuchLewo = false;
        public bool RuchPrawo = false;
        public bool Skok = false;

        public int PredkoscRuchu = 10;
        public int PredkoscSkoku = 20;

        private int punkty = 0;
        public int Punkty
        {
            get { return punkty; }
            set
            {
                punkty = value;
                GrzybobranieHandler(this); // Wywolanie eventu
            }
        }

        private bool kierunek = false;
        private float czasSkoku = 0;

        public event Grzybobranie GrzybobranieHandler; // event

        // Konstruktor
        public Mario()
        {
            // Zadanie asynchroniczne
            var t = Task.Run(async () =>
            {
                MarioBitmap = Properties.Resources.mario; // Ladowanie bitmapy do zmiennej
            });
            t.Wait(); // Czekaj az zadanie sie wykona
        }

        // Metody
        public void Rysuj(Graphics g)
        {
            var matrix = g.Transform; // Zapis obecnego polozenia transformu
            // Jezeli kierunek patrzenia = true => patrz w lewo
            if (kierunek)
            {
                g.TranslateTransform(Pozycja.X + MarioBitmap.Width, Pozycja.Y); // ustawiamy wspolrzedne
                g.ScaleTransform(-1, 1); // skalujemy => odbicie lustrzane wzgledem osi X
            }
            else // else patrz w prawo
                g.TranslateTransform(Pozycja.X, Pozycja.Y); // wspolrzedne

            g.DrawImage(MarioBitmap, 0, 0); // Wyswietlenie bitmapy
            g.Transform = matrix; // Przywrocenie transformu do stanu startowego
            RysujWynik(g);
        }

        // Metody
        private void RysujWynik(Graphics g)
        {
            var matrix = g.Transform; // Zapis obecnego polozenia transformu
            Font font = new Font("Arial", 20, FontStyle.Bold); // Czcionka
            SolidBrush brush = new SolidBrush(Color.Red); // Kolor
            g.DrawString("Wynik: " + Punkty, font, brush, 20, 20); // wyswietlenie napisu o czcione i kolorze
            g.Transform = matrix; // Przywrocenie transformu do stanu startowego
        }

        public void Ruch()
        {
            if (RuchLewo)
            {
                if (Pozycja.X > 0) // Ograniczenie w lewo
                {
                    kierunek = true;
                    Pozycja.X -= PredkoscRuchu;
                }
            }
            else if (RuchPrawo)
            {
                if (Pozycja.X <= 1024 - MarioBitmap.Width) // Ograniczenie w prawo
                {
                    kierunek = false;
                    Pozycja.X += PredkoscRuchu;
                }
            }

            if (czasSkoku > 0)
            {
                // "Fizyka" skoku
                Pozycja.Y -= PredkoscSkoku;
                czasSkoku -= 0.03f;
            }
            else
            {
                // "Fizyka" spadania obiektu do zalozonej wysokosci 
                if (Pozycja.Y <= 450 - MarioBitmap.Height)
                {
                    Pozycja.Y += PredkoscSkoku;
                }
                else if (Skok) // Jezeli nie opada => moze skoczyc ponownieu
                {
                    czasSkoku = 0.5f; // Czas trwania skoku
                    Skok = false;
                }
            }
        }
    }
}