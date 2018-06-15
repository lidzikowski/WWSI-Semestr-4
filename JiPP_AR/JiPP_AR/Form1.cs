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

namespace JiPP_AR
{
    public partial class Form1 : Form, IForm
    {
        // Kolekcja graczy - zawsze bedzie dwoch
        List<Gracz> gracze = new List<Gracz>();
        Kula kula;

        public Form1()
        {
            InitializeComponent();

            //var task = new Task(async () =>
            //{
            //    kula = new Kula(new Point(Size.Width / 2, Size.Height / 2));
            //    gracze.Add(new Gracz(this));
            //    gracze.Add(new Gracz(this));
            //});
            //task.Wait();

            // Ladowanie danych asynchronicznie
            LadujDane();
        }

        //Asynchroniczne tworzenie graczy oraz kulki
        public async Task LadujDane()
        {
            kula = new Kula(new Point(Game.Szerokosc / 2, Game.Wysokosc / 2));
            await Task.Delay(200);
            gracze.Add(new Gracz(this));
            gracze.Add(new Gracz(this));
            Wiadomosc("Zaladowano dane asynchronicznie.");
        }

        // Stworzenie gry dla pierwszego gracza
        private void buttonGracz1_Click(object sender, EventArgs e)
        {
            StworzGre(0, textBoxImie1.Text);
        }

        // Stworzenie gry dla drugiego gracza
        private void buttonGracz2_Click(object sender, EventArgs e)
        {
            StworzGre(1, textBoxImie2.Text);
        }

        private void StworzGre(int graczId, string imie)
        {
            // Jezeli dany gracz juz jest gotowy, odpusc tworzenie tego samego
            if (gracze[graczId].Gotowy)
                return;

            // Tworzenie okna z gra dla danego gracza
            Game gra = new Game()
            {
                gracz = gracze[graczId],
                przeciwnik = gracze.First(o => o != gracze[graczId]),
                kula = this.kula
            };
            gra.Pozycja((PozycjaGracza)graczId);
            gra.gracz.Imie = imie;
            gra.gracz.Pedzel = new SolidBrush(WybierzKolor());
            gra.Show();

            gra.gracz.Gotowy = true;
        }

        // Statyczna funkcja pokazujaca okno z kolorami i zwracajaca wybrany kolor
        public static Color WybierzKolor()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            return dialog.Color;
        }

        // Funkcja wyswietlajaca wiadomosc w dzienniku w obecnym watku
        // Bedzie uzywana jako event z wywolaniem w watku obiektu textBox1
        public void Wiadomosc(string wiadomosc)
        {
            Action ac = () =>
            {
                textBox1.AppendText(wiadomosc + Environment.NewLine);
                //textBox1.Text += wiadomosc + Environment.NewLine;
            };
            textBox1.Invoke(ac);
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Jezeli wszyscy nie sa gotowi przerwij zegar
            if (gracze.Find(o => !o.Gotowy) != null)
                return;

            // Petla dla kazdego gracza:
            foreach (Gracz gracz in gracze)
            {
                // Sprawdz kolizje
                kula.Kolizja(gracz);

                // Sprawdz czy nalezy sie punkt/wygrana
                if (kula.top < 10)
                {
                    Punkt(PozycjaGracza.Dol);
                    break;
                }
                else if(kula.bottom > Game.Wysokosc - 10)
                {
                    Punkt(PozycjaGracza.Gora);
                    break;
                }
            }
            kula.Sciany();
            kula.Lot();
        }

        private void Punkt(PozycjaGracza gracz)
        {
            gracze[(int)gracz].Wynik++;
            if (gracze[(int)gracz].Wynik > 7)
                Wygrana(gracze[(int)gracz]);

            kula.Pozycja = new Point(rnd.Next(30, Game.Szerokosc - 30), Game.Wysokosc / 2);
        }

        private void Wygrana(Gracz gracz)
        {
            Wiadomosc(gracz.Imie + "WYGRAL!!!");
            foreach (Gracz g in gracze)
                g.Wynik = 0;
        }
    }
}