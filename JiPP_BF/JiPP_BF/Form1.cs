using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_BF
{
    public partial class Form1 : Form
    {
        // Obiekt mario oraz kolekcja grzybkow
        Mario mario = new Mario();
        List<Grzyb> grzyby = new List<Grzyb>();

        public Form1()
        {
            InitializeComponent();
            SworzGrzybki(rnd.Next(1, 7)); // Na start stworz losowa ilosc grzybow
        }

        private void pictureBoxBackground_Paint(object sender, PaintEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew(); // Obiekt zegara

            // Petla wywolujaca funkcje rysowania dla kazdego elementu kolekcji
            foreach (Grzyb grzyb in grzyby)
            {
                grzyb.Rysuj(e.Graphics); // Rysuj kazdego grzybka
            }

            // Wywolanie funkcji rysujacej
            mario.Rysuj(e.Graphics);

            sw.Stop(); // Zatrzymanie zegara
            Text = "FPS: " + ((int)(1 / sw.Elapsed.TotalSeconds)).ToString(); // Licznik fps w tytule
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Sprawdzanie kolizji w kazdym grzybku
            foreach (Grzyb grzyb in grzyby)
            {
                if (grzyb.Kolizja(mario)) // Sprawdzenie kolizji
                {
                    mario.Punkty++; // Dodaj punkt
                    grzyby.Remove(grzyb); // Usun obecnego grzyba za zdobyty punkt
                    SworzGrzybki(rnd.Next(1, 7)); // Stworz losowa ilosc grzybow
                    break;
                }
            }

            // Silnik napedowy mario
            mario.Ruch();

            // Odswierzenie grafiki
            Refresh();
        }

        Random rnd = new Random(); // Obiekt losowosci

        // Metoda tworzenia grzybow
        private void SworzGrzybki(int ilosc)
        {
            // Nowy watek odpowiedzialny za stworzenie po jakims czasie grzybki
            Thread t = new Thread(() =>
            {
                grzyby.Clear(); // Czyszczenie kolekcji z grzybami
                Thread.Sleep(1000); // Uspienie watku na 1 sekunde
                for (int i = 0; i < ilosc; i++) // Petla ilosci tworzenia grzybow
                {
                    int x = rnd.Next(100, 900); // losowy X
                    int y = rnd.Next(100, 300); // losowy Y
                    grzyby.Add(new Grzyb(new Point(x, y), mario)); // Dodanie do kolekcji grzybow nowego grzyba
                }
            });
            t.Start(); // Uruchomienie stworzonego watku
        }

        #region Obsluga klawiszy
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (!mario.RuchLewo)
                    mario.RuchLewo = true;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (!mario.RuchPrawo)
                    mario.RuchPrawo = true;
            }
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (!mario.Skok)
                    mario.Skok = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (mario.RuchLewo)
                    mario.RuchLewo = false;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (mario.RuchPrawo)
                    mario.RuchPrawo = false;
            }
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (mario.Skok)
                    mario.Skok = false;
            }
        }
        #endregion
    }
}