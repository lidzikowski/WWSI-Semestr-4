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

namespace JiPP_DG
{
    public partial class Form1 : Form
    {
        // obiekt gracza
        Gracz gracz;
        // kolekcja z obiektami terenu / kolizjami
        List<PictureBox> obiektyTerenu = new List<PictureBox>();

        Random rnd = new Random(); // obiekt randomowosci
        bool koniecGry = false;

        public Form1()
        {
            InitializeComponent();

            // stworzenie nowego obiektu
            gracz = new Gracz(pictureBoxGracz);

            // asynchroniczne zadanie / funkcja anonimowa
            new Task(async () =>
            {
                await Task.Delay(100);
                // przypisanie do zdarzenia obiektu, metode z obcej klasy (tej)
                gracz.WiadomoscHandler += Wiadomosc;
            }).Start();

            // dodanie referencji do obiektow otoczenia do kolekcji z nimi
            obiektyTerenu.Add(pictureBoxZiemia);
            obiektyTerenu.Add(pictureBoxRura1);
            obiektyTerenu.Add(pictureBoxRura2);
        }

        // metoda zmieniajaca nazwe okna, uzycie jako metody do zdarzenia
        private void Wiadomosc(string msg)
        {
            // akcja / lambda - funkcja anonimowa
            Action ac = () =>
            {
                Text = msg;
            };
            Invoke(ac); // wywolanie funkcji anonimowej
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // jezeli jest koneic gry, wyswietl napis z wynikiem
            if (koniecGry)
            {
                e.Graphics.DrawString("Koniec gry, twoj wynik to " + gracz.Wynik, new Font("Arial", 22), Brushes.Red, 100, 200);
                return;
            }
            else
            {
                // jezeli gra dalej dziala, narysuj slonce
                e.Graphics.FillEllipse(Brushes.Yellow, 50, 50, 70, 70);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // koniec gry = nic nie licz return
            if (koniecGry)
                return;

            // ruch gracza sprawdzajacy kolizje
            if (gracz.Ruch(obiektyTerenu))
            {
                // kolizja wykryta = koniec gry + odswierzenie grafiki
                koniecGry = true;
                Refresh();
                return;
            }

            foreach (PictureBox obiekt in obiektyTerenu.GetRange(1, 2))
            {
                // jezeli obiekt wyjedzie za daleko w lewo
                if (obiekt.Left < obiekt.Width)
                {
                    obiekt.Left = rnd.Next(70, 80) * 10; //ustaw mu losowy odstep od lewej krawedzie
                    gracz.Wynik += 0.5f; // daj graczowi 0.5 punkta do wyniku
                }
                else
                    obiekt.Left -= 9; // jezeli jest okej, przesun obiekt w lewo
            }

            Refresh();
        }

        // metody do obslugi zdarzen klawiszy
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gracz.Skok = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gracz.Skok = false;
        }
    }
}
