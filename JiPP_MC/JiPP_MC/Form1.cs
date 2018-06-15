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

namespace JiPP_MC
{
    public delegate void ZmianaKoloru(); // deklaracja delegata

    public partial class Form1 : Form
    {
        Gracz gracz = new Gracz(); // obiekt gracza
        public static List<Strzal> Strzaly = new List<Strzal>(); // kolekcja pociskow
        List<Gracz> przeciwnicy = new List<Gracz>(); // kolekcja przeciwnikow

        event ZmianaKoloru ZmianaKoloruHandler; // deklaracja eventu
        List<Color> KoloryTla = new List<Color>();

        // zmienna z punktami gracza oraz wywolanie eventu we wlasciwosci
        int punkty = 0;
        public int Punkty
        {
            get { return punkty; }
            set
            {
                punkty = value;
                ZmianaKoloruHandler(); // wywolanie eventu
            }
        }

        public Form1()
        {
            InitializeComponent();
            Cursor.Hide(); // chowanie kursora
            StworzPrzeciwnikow(); // wywolanie asynchronicznego zadania

            // stworzenie kolekcji z kolorami tla
            KoloryTla.Add(Color.Aqua);
            KoloryTla.Add(Color.Green);
            KoloryTla.Add(Color.LightYellow);
            KoloryTla.Add(Color.LightCyan);
            KoloryTla.Add(Color.Salmon);
            KoloryTla.Add(Color.Silver);

            ZmianaKoloruHandler += ZmienKolorTla; // przypisanie metody do eventu
        }

        Random rnd = new Random(); // obiekt losowosci

        // Metoda zmiany koloru, do wykorzystania w evencie
        private void ZmienKolorTla()
        {
            // wylosowanie koloru i ustawienie go jako nowy kolor tla
            pictureBox1.BackColor = KoloryTla[rnd.Next(0, KoloryTla.Count - 1)];
        }

        // asynchroniczne zadanie tworzace przeciwnikow
        private async Task StworzPrzeciwnikow()
        {
            Brush[] kolory = new Brush[] { // tablica kolorow
                Brushes.OrangeRed,
                Brushes.Olive,
                Brushes.Moccasin,
                Brushes.Navy,
                Brushes.LightYellow,
                Brushes.DarkCyan
            };
            int max = 17;
            for (int i = 1; i <= max; i++)
            {
                // tworzenie obieku przeciwnika i przypisanie mu wartosci
                Gracz g = new Gracz();
                g.Pozycja.Y = 100 + rnd.Next(-70, 100);
                g.Pozycja.X = i * 2;
                g.Pedzel = kolory[rnd.Next(0, kolory.Length - 1)]; // losowy kolor z tablicy
                przeciwnicy.Add(g); // dodanie go do kolekcji przeciwnikow
                Text = string.Format("Trwa ladowanie... {0} / {1}", i, max);
                await Task.Delay(10); // zadanie czeka 10 sekund
            }
            Text = "Przeciwnicy stworzeni, czas na walke!";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // jezeli koniec gry wyswietl napis:
            if (koniecgry)
            {
                Text = "Przegrales...";
                e.Graphics.DrawString("Zdobyles " + Punkty + " punktow!", new Font("Arial", 26), Brushes.DarkOliveGreen, new Point(100, 120));
                e.Graphics.DrawString("Wcisnij R aby zresetowac gre.", new Font("Arial", 24), Brushes.Red, new Point(100, 150));
                return;
            }

            gracz.Rysuj(e.Graphics); // rysowanie obiektu gracza

            foreach (Strzal strzal in Strzaly) // rysowanie pociskow
                strzal.Rysuj(e.Graphics);

            foreach (Gracz przeciwnik in przeciwnicy) // rysowanie przeciwnikow
                przeciwnik.Rysuj(e.Graphics);
        }

        bool koniecgry = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (koniecgry) // jezeli koniec gry, nic nie rob
                return;

            // wyswietlenie wyniku w nazwie okna
            if (Punkty != 0)
                Text = "Wynik: " + Punkty;

            gracz.Strzal(); // wywolanie metody strzelania dla gracza

            foreach (Strzal strzal in Strzaly) // sprawdzanie strzal
            {
                if (strzal.Ruch()) // pocisk poza ekranem = usun
                {
                    Strzaly.Remove(strzal);
                    break;
                }
                if (strzal.Pozycja.X - 1 == gracz.Pozycja.X) // pocisk w okolicy gracza
                {
                    // nastepuje trafienie / wykrycie
                    if (strzal.Pozycja.Y > gracz.Pozycja.Y - 10 && strzal.Pozycja.Y < gracz.Pozycja.Y + 10)
                    {
                        Strzaly.Remove(strzal); // usuniecie pocisku z kolekcji pociskow
                        koniecgry = true; // ustanowienie konca gry
                        Refresh(); // odswierzenie grafiki aby wyswietlic napis "koniec gry"
                        return;
                    }
                }
                foreach (Gracz przeciwnik in przeciwnicy) // sprawdzanie przeciwnikow
                {
                    if (strzal.Pozycja.X - 1 == przeciwnik.Pozycja.X) // pocisk w okolicy przeciwnika
                    {
                        // nastepuje trafienie / wykrycie
                        if (strzal.Pozycja.Y > przeciwnik.Pozycja.Y - 10 && strzal.Pozycja.Y < przeciwnik.Pozycja.Y + 10)
                        {
                            przeciwnicy.Remove(przeciwnik); // usuniecie przeciwnika z kolekcji
                            Strzaly.Remove(strzal); // usuniecie pocisku z kolekcji
                            Punkty++; // dodanie punktu
                            return;
                        }
                    }
                }
            }

            // nowy watek z metoda anonimowa / lambda
            new Thread(() =>
            {
                foreach (Gracz przeciwnik in przeciwnicy)
                {
                    int range = 3;
                    // sprawdzanie czy gracz jest w okolicy przeciwnika
                    if (przeciwnik.Pozycja.X > gracz.Pozycja.X - range && przeciwnik.Pozycja.X < gracz.Pozycja.X + range)
                        przeciwnik.Shot = true; // jezeli jest to strzelaj
                    else
                        przeciwnik.Shot = false; // jezeli nie, nie strzelaj lub przestan

                    przeciwnik.Strzal(false); // funkcja strzalu
                }
            }).Start(); // start watku

            // jezeli brak przeciwnikow, stworz nowych
            if (przeciwnicy.Count == 0)
                StworzPrzeciwnikow();

            Refresh(); // odswierzenie grafiki
        }

        // Obslugi klawiszy
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X < pictureBox1.Width - gracz.Wielkosc.Width)
                gracz.Pozycja.X = e.X / gracz.Wielkosc.Width; // nowa pozycja gracza wzgledem myszy
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gracz.Shot)
                gracz.Shot = true; // spacja wcisnieta = strzelanie
            if (koniecgry && e.KeyCode == Keys.R) // Reset gry
            {
                gracz = new Gracz(); // reset obiektu gracza
                Strzaly.Clear(); // wyczyszczenie kolekcji pociskow
                przeciwnicy.Clear(); // wyczyszczenie kolekcji przeciwnikow
                StworzPrzeciwnikow(); // wywolanie asynchronicznej metody tworzacej nowych przeciwnikow
                koniecgry = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gracz.Shot)
                gracz.Shot = false; // spacja puszczona = koniec strzelania
        }
    }
}