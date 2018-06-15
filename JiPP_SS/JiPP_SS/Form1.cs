using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_SS
{
    public partial class Form1 : Form
    {
        // Kolekcja z jedzeniem
        List<Punkt> Jedzenie = new List<Punkt>();
        Snake Waz = new Snake(); // obiekt weza

        public static List<Brush> Kolory = new List<Brush>(); // statyczna kolekcja z kolorami elementow weza / jedzenia

        public Form1()
        {
            InitializeComponent();

            // Dodanie do kolekcji kilku kolorow
            Kolory.Add(Brushes.AliceBlue);
            Kolory.Add(Brushes.Aqua);
            Kolory.Add(Brushes.Beige);
            Kolory.Add(Brushes.BlanchedAlmond);
            Kolory.Add(Brushes.Brown);
            Kolory.Add(Brushes.Chocolate);
            Kolory.Add(Brushes.Cyan);
            Kolory.Add(Brushes.DarkMagenta);
            Kolory.Add(Brushes.GreenYellow);
            Kolory.Add(Brushes.LightGoldenrodYellow);
            Kolory.Add(Brushes.Gold);
        }

        // Metoda rysowania grafiki w elemencie pictureBox1
        bool koniec = false;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Jezeli to koniec gry wyswietl napis informacyjny i mozliwosc resetu gry.
            if(koniec)
            {
                Text = "Koniec gry";
                e.Graphics.DrawString("Koniec gry, twoj wynik to " + Waz.Punkty, new Font("Arial", 20), Brushes.YellowGreen, new PointF(100, 150));
                e.Graphics.DrawString("Nacisnij R aby zresetowac gre.", new Font("Arial", 20), Brushes.YellowGreen, new PointF(100, 200));
                return;
            }

            // w przeciwnym wypadku narysuj weza, oraz jedzenie na ekranie
            Waz.Rysuj(e.Graphics);
            RysujJedzenie(e.Graphics);

            // Jezeli mamy wiecej niz 0 punktow, wyswietlamy wynik w nazwie okna
            if (Waz.Punkty > 0)
                Text = "Snake! Wynik: " + Waz.Punkty;
        }

        Random rnd = new Random(); // obiekt losowosci
        // metoda zegarka (wykonuj te polecenia co X czasu)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Uruchomienie metody ruszajacej wezem i zwracajaca czy waz wyjechal poza okno gry, wowczas nastepuje koniec gry
            if(Waz.Ruch(Jedzenie))
            {
                koniec = true;
            }

            // jezeli na ekranie jest mniej niz 10 jedzenia, dodaj nowe
            if (Jedzenie.Count < 10)
            {
                // metoda asynchroniczna przy uzyciu lambdy - funkcji anonimowej
                Action ac = async () =>
                {
                    // dodaj do kolekcji nowy element Punkt z losowym kolorem jako obiekt jedzenia
                    Jedzenie.Add(new Punkt() { X = rnd.Next(1, 50), Y = rnd.Next(1, 28), Kolor = Kolory[rnd.Next(0, Kolory.Count - 1)] });
                };
                Invoke(ac); // wywolanie akcji w obecnym watku
            }
            Refresh(); // odswierzenie grafiki
        }

        // prywatna metoda rysowania jedzenia
        private void RysujJedzenie(Graphics g)
        {
            // po kazdym elemencie jedzenia
            foreach (Punkt p in Jedzenie)
            {
                // narysuj ten element
                g.FillEllipse(p.Kolor, new Rectangle(p.X * 16, p.Y * 16, 16, 16));
            }
        }

        // obsluga klawiszy
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Klawisz(e, new Keys[] { Keys.Up, Keys.W }, Kierunki.Gora);
            Klawisz(e, new Keys[] { Keys.Down, Keys.S }, Kierunki.Dol);
            Klawisz(e, new Keys[] { Keys.Left, Keys.A }, Kierunki.Lewo);
            Klawisz(e, new Keys[] { Keys.Right, Keys.D }, Kierunki.Prawo);

            // jezeli nastapil koniec gry, jest mozliwosc restartu gry
            if (koniec)
            {
                if (e.KeyCode == Keys.R) // pod klawiszem R jak reset
                {
                    koniec = false; // zmien koniec na falsz
                    Text = "Snake!"; // ustaw nowa nazwe okna
                    Waz = new Snake(); // na nowo stworz obiek weza
                }
            }
        }

        // metoda klawiszy, przyjmuje obecnie wcisniety klawisz, sprawdza czy jest on zdefiniowany w tablicy, i jaki ma byc to kierunek
        private void Klawisz(KeyEventArgs e, Keys[] key, Kierunki kierunek)
        {
            if (e.KeyCode == key[0] || e.KeyCode == key[1])
            {
                if (Waz.Kierunek != kierunek)
                    Waz.Kierunek = kierunek;
            }
        }
    }
}
