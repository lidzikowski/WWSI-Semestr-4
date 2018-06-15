using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_AR
{
    public partial class Game : Form
    {
        public Gracz gracz;
        public Gracz przeciwnik;
        public Kula kula;

        public static int Szerokosc = 800;
        public static int Wysokosc = 450;

        public Game()
        {
            InitializeComponent();
            //Szerokosc = pictureBox1.Size.Width;
            //Wysokosc = pictureBox1.Size.Height;
        }

        // Funkcja ustawiajaca polozenie gracza w grze
        public void Pozycja(PozycjaGracza pozycjaGracza)
        {
            int szerokosc = (Size.Width / 2) - (gracz.Rozmiar.Width / 2);

            if (pozycjaGracza == PozycjaGracza.Gora)
                gracz.Pozycja = new Point(szerokosc, 20);
            else
                gracz.Pozycja = new Point(szerokosc, Size.Height - 70);
        }

        // Zegar
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ruch gracza
            gracz.Ruch(this);

            // Przeladowanie grafiki = Game_Paint
            Refresh();
        }

        // Akcje do wcisnietych przyciskow
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if (!gracz.RuchLewo) gracz.RuchLewo = true;
            if (e.KeyCode == Keys.Right)
                if (!gracz.RuchPrawo) gracz.RuchPrawo = true;
        }

        // Akcje do puszczonych przyciskow
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if (gracz.RuchLewo) gracz.RuchLewo = false;
            if (e.KeyCode == Keys.Right)
                if (gracz.RuchPrawo) gracz.RuchPrawo = false;
        }

        // Przy zamknieciu zmien gotowosc gracza
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            gracz.Gotowy = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew(); // fps start

            // Rysuj gracza
            gracz.Rysuj(e.Graphics);

            // Rysuj jego przeciwnika
            if (przeciwnik.Gotowy)
                przeciwnik.Rysuj(e.Graphics);

            // Rysuj kulke
            kula.Rysuj(e.Graphics);

            sw.Stop(); // fps stop
            Text = gracz.Imie + " | FPS: " + ((int)(1 / sw.Elapsed.TotalSeconds)).ToString(); // pokazanie imienia oraz fpsow w tytule okna
        }
    }
}
