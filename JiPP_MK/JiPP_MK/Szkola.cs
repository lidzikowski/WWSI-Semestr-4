using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_MK
{
    public partial class Szkola : Form
    {
        public Szkola()
        {
            InitializeComponent();
        }

        private void Szkola_Load(object sender, EventArgs e)
        {
            // Deklaracja akcji do wykonania (metoda synchroniczna)
            Action a = new Action(() =>
            {
                // Stworzenie kolekcji z funkcji i przypisanie ich do zmiennej z uczniami
                Uczniowie = StworzUczniow(50);
            });

            // Wywolanie akcji aby zostala wykonana w watku programu
            Invoke(a);

            // Odswiezenie widoku
            OdswiezListy();
        }

        // Kolekcja z uczniami
        List<Uczen> Uczniowie;

        /// <summary>
        /// Zwraca zaznaczony obiekt w listBoxUczniowie jako obiekt typu Uczen
        /// </summary>
        Uczen ZaznaczonyUczen
        {
            get
            {
                return listBoxUczniowie.SelectedItem as Uczen;
            }
        }

        // Obiekt losowosci
        Random random = new Random();

        /// <summary>
        /// Funkcja tworzaca kolekcje z obiektami typu Uczen.
        /// </summary>
        /// <param name="ilosc">Ilosc obiektow ktore maja zostac stworzone.</param>
        /// <returns>Kolekcja z obiektami.</returns>
        private List<Uczen> StworzUczniow(int ilosc)
        {
            // Deklaracja kolekcji
            List<Uczen> uczniowie = new List<Uczen>();

            // Tablica z imionami zenskimi
            string[] imionaZenskie = { "Ania", "Zosia", "Julia", "Ola" };

            // Tablica z imionami meskimi
            string[] imionaMeskie = { "Adam", "Janek", "Mariusz", "Bartek" };

            // Tablica z nazwiskami
            string[] nazwiska = { "Nowak", "Wozniak", "Kowalczyk", "Wójcik", "Mazur", "Krawczyk" };
            
            // Petla tworzaca pewna ilosc obiektow typu Uczen
            for (int i = 0; i < ilosc; i++)
            {
                // Deklaracja informacji o obiekcie
                string imie, nazwisko;
                Plec plec;
                Klasa klasa;

                // Losowanie plci obiektu
                if (random.Next(0, 100) > 50)
                {
                    // Losowanie imienia zenskiego
                    imie = imionaZenskie[random.Next(0, imionaZenskie.Length)];
                    plec = Plec.Dziewczynka;
                }
                else
                {
                    // Losowanie imienia meskiego
                    imie = imionaMeskie[random.Next(0, imionaMeskie.Length)];
                    plec = Plec.Chlopiec;
                }

                // Losowanie nazwiska obiektu
                nazwisko = nazwiska[random.Next(0, nazwiska.Length)];
                
                // Losowanie klasy w ktorej bedzie obiekt
                klasa = (Klasa)random.Next(0, 5);

                // Stworzenie obiektu ucznia z wyzej stworzonych informacji o nim
                Uczen uczen = new Uczen(imie, nazwisko, plec, klasa);

                // Dodanie obiektu do kolekcji z uczniami
                uczniowie.Add(uczen);
            }

            // Zwracanie stworzonej kolekcji z obiektami
            return uczniowie;
        }

        /// <summary>
        /// Usuniecie i przypisanie na nowo kolekcji zrodlowych do listBox'ow
        /// </summary>
        private void OdswiezListy()
        {
            // Przypisanie kolekcji z uczniami do listBox'a
            listBoxUczniowie.DataSource = null;
            listBoxUczniowie.DataSource = Uczniowie;

            // Tablica klas z obiektami typu ListBox
            ListBox[] klasy = { listBoxPierwsza, listBoxDruga, listBoxTrzecia, listBoxCzwarta, listBoxPiata };

            // Tablice z tekstami, w odpowiedniej kolejnosci wedlug klas wyzej
            Label[] uczniow = { label1Uczniow, label2Uczniow, label3Uczniow, label4Uczniow, label5Uczniow };
            Label[] ucieklo = { label1Ucieklo, label2Ucieklo, label3Ucieklo, label4Ucieklo, label5Ucieklo };
            Label[] frekwencja = { label1Frekwencja, label2Frelwemcja, label3Frekwencja, label4Frekwencja, label5Frekwencja };

            // Petla dla wszystkich klas
            for (int i = 0; i < klasy.Length; i++)
            {
                // Odswiezenie ListBox'ow
                klasy[i].DataSource = null;

                // Stworzenie kolekcji w ktorej beda uczniowie nalezacy do obecnie tworzonej klasy
                List<Uczen> uczniowie = Uczniowie.Where(o => o.Klasa == (Klasa)i).ToList();

                // Przypisanie kolekcji do ListBox'a klasy
                klasy[i].DataSource = uczniowie;

                // Usuniecie zaznaczenia elementu
                klasy[i].SelectedIndex = -1;

                // Przypisanie tekstow, wlasciwosci do odpowiednich pol tekstowych
                uczniow[i].Text = $"Uczniów: {uczniowie.Count}";

                // Zliczenie ucieczek uczniow nalezacych do obecnej klasy
                int ucieczek = 0;
                foreach (Uczen uczen in uczniowie)
                {
                    if (uczen.CzyDzisUciekl)
                        ucieczek++;
                }

                ucieklo[i].Text = $"Uciekło: {ucieczek}";

                // Wyliczenie procentu obecnosci
                int frek = (int)(uczniowie.Count > 0 ? ((((float)uczniowie.Count - (float)ucieczek) / (float)uczniowie.Count) * 100.0f) : 0);
                
                // Kolor frekwencji oraz napis
                frekwencja[i].ForeColor = KolorFrekwencji(frek);
                frekwencja[i].Text = $"Frekwencja: {frek} %";
            }
        }

        /// <summary>
        /// Funkcja tworzaca kolor w zaleznosci od procentu frekwencji
        /// </summary>
        /// <param name="liczba">Liczba obecnosci.</param>
        /// <returns>Kolor</returns>
        public static Color KolorFrekwencji(int liczba)
        {
            return liczba > 80 ? Color.Green : liczba > 50 ? Color.DarkGoldenrod : Color.Red;
        }

        private void buttonDodajUcznia_Click(object sender, EventArgs e)
        {
            // Stworzenie nowego obiektu z formularzem
            NowyUczen form = new NowyUczen();

            // Przypiecie funkcji do zdarzenia w stworzonym obiekcie
            form.OnDodajUcznia += DodajUcznia;

            // Wyswietlenie stworzonego okna w trybie dialogowym
            form.ShowDialog();
        }

        private void buttonUsunUcznia_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy zaznaczony obiekt nie jest nullem
            if (ZaznaczonyUczen == null)
                return;

            // Wiadomosc w konsoli
            textBoxKonsola.Text += $"Uczen zostal usuniety {ZaznaczonyUczen.ToString()} {Environment.NewLine}";
            
            // Usuniecie zaznaczonego ucznia z kolekcji wszystkich uczniow
            Uczniowie.Remove(ZaznaczonyUczen);

            // Odswiezenie wszystkich list
            OdswiezListy();
        }

        private void listBoxUczniowie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sprawdzenie czy zaznaczony obiekt nie jest nullem
            if (ZaznaczonyUczen == null)
                return;

            // Przypisanie informacji o zaznaczonym uczniu do elementow interfejsu
            labelImie.Text = $"Imie: {ZaznaczonyUczen.Imie}";
            labelNazwisko.Text = $"Nazwisko: {ZaznaczonyUczen.Nazwisko}";
            labelPlec.Text = $"Plec: {ZaznaczonyUczen.Plec}";
            labelKlasa.Text = $"Klasa: {ZaznaczonyUczen.Klasa}";
            labelOdbytychZajec.Text = $"Odbyte Zajecia: {ZaznaczonyUczen.OdbyteZajecia}";
            labelUcieczki.Text = $"Ucieczki: {ZaznaczonyUczen.Ucieczki}";

            // Wyznaczanie koloru frekwencji
            labelFrekwencja.ForeColor = KolorFrekwencji(ZaznaczonyUczen.Frekwencja);
            labelFrekwencja.Text = $"Frekwencja: {ZaznaczonyUczen.Frekwencja} %";
        }

        /// <summary>
        /// Funkcja dodajaca ucznia stworzonego w oknie dialogowym - SDI
        /// </summary>
        /// <param name="uczen">Obiekt ucznia ktory zostanie dodany do kolekcji uczniow programu.</param>
        private void DodajUcznia(Uczen uczen)
        {
            // Dodanie ucznia do kolekcji z uczniami
            Uczniowie.Add(uczen);

            // Wywolanie funkcji odswiezajacej listy
            OdswiezListy();

            // Wyswietlenie wiadomosci zdarzeniowej
            textBoxKonsola.Text += $"[Zdarzenie] Dodano nowego ucznia {uczen.ToString()} {Environment.NewLine}";
        }

        int licznik = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            // Zliczamy prace zegarka, praca ma byc wykonywana co 50 = co 0.1 * 50 = 5 sekund
            licznik++;
            if (licznik > 50)
            {
                // Co 5 sekund rozpoczyna sie nowa lekcja, losowanie uczniow, ktorzy uciekna z lekcji
                int iloscUciekinierow = random.Next(0, Uczniowie.Count / 5);

                // Lista ucikinierow
                List<Uczen> dzisiejsiUcikinierzy = new List<Uczen>();

                // Petla dla ilosci uciekinierow
                for (int i = 0; i < iloscUciekinierow; i++)
                {
                    // Generowanie numeru ucznia
                    int idUcikiniera = random.Next(0, Uczniowie.Count);

                    // Dodanie ucikiniera do kolekcji
                    dzisiejsiUcikinierzy.Add(Uczniowie[idUcikiniera]);
                }

                // Wyszukujemy uczniow ktorzy dzisiaj beda w szkole
                foreach (Uczen uczen in Uczniowie)
                {
                    if(dzisiejsiUcikinierzy.Contains(uczen))
                    {
                        uczen.DzisWagary();
                    }
                    else
                    {
                        uczen.DzisDoSzkoly();
                    }
                }

                // Wiadomsoc o ucieczkach na konsoli
                textBoxKonsola.Text += $"Dzis jest {iloscUciekinierow} uciekinierów. {Environment.NewLine}";

                // Odswiezenie list
                OdswiezListy();

                // Resetowanie pracy zegara
                licznik = 0;
            }

            // Odswiezenie kontrolek, glownie rysowanej grafiki
            Refresh();
        }

        private void panelEmocje_Paint(object sender, PaintEventArgs e)
        {
            // Jezeli zaden uczen nie jest zaznaczony
            if (ZaznaczonyUczen == null)
                return;

            // Wywolanie funkcji rysowania emocji zaznaczonego ucznia i przekazania mu obiektu grafiki na ktorej bedzie rysowal
            ZaznaczonyUczen.RysujEmocje(e.Graphics, panelEmocje);
        }

        private void panelEmocje_MouseMove(object sender, MouseEventArgs e)
        {
            // Jezeli zaden uczen nie jest zaznaczony
            if (ZaznaczonyUczen == null)
                return;

            // Jezeli nowy punkt miesci sie w granicy okna
            if (e.X >= 30 && e.X <= panelEmocje.Size.Width - 30)
                ZaznaczonyUczen.X = e.X; // Przypisz nowa pozycje X
        }

        // Deklaracja tablicy z kolorami
        Color[] kolory = { Color.Blue, Color.Violet, Color.Gold, Color.Red, Color.Salmon };

        private void panelEmocje_MouseDown(object sender, MouseEventArgs e)
        {
            // Jezeli zaden uczen nie jest zaznaczony
            if (ZaznaczonyUczen == null)
                return;

            // Wylosowanie koloru i stworzenie z niego dlugopisu
            ZaznaczonyUczen.pen = new Pen(kolory[random.Next(0, kolory.Length)]);
        }
    }
}
