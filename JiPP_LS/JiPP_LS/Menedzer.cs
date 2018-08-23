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

namespace JiPP_LS
{
    public partial class Menedzer : Form, IPracownik
    {
        public Menedzer()
        {
            InitializeComponent();
        }

        // Publiczna kolekcja pracownikow
        private List<Pracownik> pracownicy = new List<Pracownik>();

        private void Menedzer_Load(object sender, EventArgs e)
        {
            // Wywolanie funkcji tworzocej pewna ilosc pracownikow i przypisanie ich do kolekcji
            pracownicy = StworzPracownikow(15);

            // Przypisanie kolekcji jako zrodlo danych dla listy w formularzu
            listBoxPracownicy.DataSource = pracownicy;
        }

        /// <summary>
        /// Funkcja tworzaca kolekcje z obiektami typu Pracownik.
        /// </summary>
        /// <param name="ilosc">Ilosc stworzonych obiektow w kolekcji.</param>
        /// <returns>Kolekcja obiektow Pracownik.</returns>
        private List<Pracownik> StworzPracownikow(int ilosc)
        {
            // Obiekt losowosci
            Random random = new Random();

            // Tablica z imionami obiektow
            string[] imiona = { "Jan", "Andrzej", "Janusz", "Anna", "Monika", "Zofia" };

            // Tablica z nazwiskami obiektow
            string[] nazwiska = { "Nowak", "Mazur", "Kowalczyk", "Wojcik" };

            // Pusta kolekcja ktora bedzie wypelniana
            List<Pracownik> pracownicy = new List<Pracownik>();

            // Tworzenie obiektow i dodawanie ich do kolekcji
            for (int i = 0; i < ilosc; i++)
            {
                // Wylosowanie imiona z tablicy imion
                string imie = imiona[random.Next(0, imiona.Length)];

                // Wylosowanie nazwiska z tablicy nazwisk
                string nazwisko = nazwiska[random.Next(0, nazwiska.Length)];

                // Wylosowanie wieku Pracownika
                int wiek = random.Next(18, 50);

                // Tworzenie obiektu pracownika z wylosowanych wartosci
                Pracownik pracownik = new Pracownik(imie, nazwisko, wiek);

                // Przypiecie metod do zdarzen obiektu
                pracownik.PrzypnijZdarzenie(this);

                // Dodanie pracownika do kolekcji
                pracownicy.Add(pracownik);
            }

            // Zwracamy stworzona kolekcje ze stworzonymi obiektami
            return pracownicy;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // Stworzenie obiektu formularza do tworzenia nowego pracownika
            ModyfikacjaPracownika form = new ModyfikacjaPracownika();

            // Przypisanie funkcji do zdarzenia
            form.OnDodajPracownika += DodajPracownika;

            // Ustawienie trybu okna
            form.TrybOkna(Operacja.Dodaj);

            // Wyswietlenie stworzonego okna jako dialogowe
            form.ShowDialog();
        }

        /// <summary>
        /// Dodanie obiektu Pracownik do kolekcji z obiektami typu Pracownik oraz odswierzenie kolekcji na formularzu.
        /// Funkcja do zdarzenia.
        /// </summary>
        /// <param name="pracownik">Obiekt typu Pracownik.</param>
        private void DodajPracownika(Pracownik pracownik)
        {
            // Dodanie pracownika do kolekcji
            pracownicy.Add(pracownik);

            // Wywolanie funkcji odswierzajaca formularz
            OdswierzListePracownikow();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            // Jezeli nie ma nic zaznaczonego, nie rob nic
            if (listBoxPracownicy.SelectedIndex < 0)
                return;

            // Stworzenie i wyswietlenie okna dialogowego potwierdzajacego usuniecie obiektu
            DialogResult dialog = MessageBox.Show($"Czy napewno usunac {ZaznaczonyPracownik.ToString()}?", "Usuwanie pracownika", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                // Usun zaznaczony element
                pracownicy.Remove(ZaznaczonyPracownik);

                // Wywolanie funkcji odswierzajaca formularz
                OdswierzListePracownikow();
            }
        }

        private void OdswierzListePracownikow()
        {
            // Odswierzenie kolekcji w formularzu
            listBoxPracownicy.DataSource = null;
            listBoxPracownicy.DataSource = pracownicy;
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            // Jezeli nie ma nic zaznaczonego, nie rob nic
            if (listBoxPracownicy.SelectedIndex < 0)
                return;

            // Stworzenie obiektu formularza do edycji pracownika
            ModyfikacjaPracownika form = new ModyfikacjaPracownika();

            // Przypisanie funkcji do zdarzenia
            form.OnOdswierzPracownikow += OdswierzListePracownikow;

            // Ustawienie trybu okna
            form.TrybOkna(Operacja.Edytuj, ZaznaczonyPracownik);

            // Wyswietlenie stworzonego okna jako dialogowe
            form.ShowDialog();
        }

        private void listBoxPracownicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Odpiecie zdarzenia od wszystkich obiektow pracownik ktorzy nie sa zaznaczonym pracownikiem
            foreach (Pracownik p in pracownicy.Where(o => o != ZaznaczonyPracownik))
            {
                // Wywolanie metody odpinajacej metode od zdarzenia tego obiektu
                p.OdepnijZdarzenie(this);
            }

            // Brak pracownika, koniec funkcji
            if (ZaznaczonyPracownik == null)
                return;

            // Wywolanie metody ktora przypnie metode do zdarzenia obiektu
            ZaznaczonyPracownik.PrzypnijZdarzenie(this);

            // Manualne wywolanie funkcji aktualizujacej interfejs
            Pracownik_OnAktualizacja(ZaznaczonyPracownik);
        }

        int operacja = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            operacja++; // zwiekszanie operacje zegara

            if (operacja >= 5) // co 5 operacji zegara wykonuj:
            {
                // Zadanie do wykonania
                Action a = new Action(() =>
                {
                    // Petla dla wszystkich pracownikow w kolekcji, wykonujaca ich prace
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        pracownik.Pracuj();
                    }
                });

                // Wywolanie zadania
                Invoke(a);

                operacja = 0; // reset operacji
            }

            ZaznaczonyPracownik?.Ruch();

            // Odswierzenie kontrolek, glownie funkcji rysujacej
            Refresh();
        }

        public void Pracownik_OnAktualizacja(Pracownik pracownik)
        {
            // Przypisanie naglowka do obiektu GroupBox
            groupBoxPracownik.Text = $"Pracownik {pracownik.ToString()}";

            // Przypisanie reszty danych obiektu do obiektow Label
            labelImie.Text = $"Imie: {pracownik.Imie}";
            labelNazwisko.Text = $"Nazwisko: {pracownik.Nazwisko}";
            labelWiek.Text = $"Wiek: {pracownik.Wiek}";
            labelTypPracownika.Text = $"Typ pracownika: {pracownik.Typ}";
            labelZarobki.Text = $"Zarobki: {pracownik.Zarobki}";
            labelGotowka.Text = $"Gotowka: {pracownik.ZarobionaGotowka}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Wywolanie funkcji obiektu ktora bedzie rysowac zaznaczonego pracownika
            // ? -> sprawdzenie czy obiekt nie jest nullem
            ZaznaczonyPracownik?.Rysuj(e.Graphics);
        }

        /// <summary>
        /// Prywatna wlasciwosc zwracajaca zaznaczonego pracownika w liscie z pracownikami
        /// </summary>
        private Pracownik ZaznaczonyPracownik
        {
            get
            {
                // Zwroc zaznaczony element w liscie z obiektami i bedzie on obiektem typu Pracownik
                return listBoxPracownicy.SelectedItem as Pracownik;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Jezeli zaden pracownik nie jest zaznaczony, przerwij
            if (ZaznaczonyPracownik == null)
                return;

            // Jezeli pozycja klikniecia jest po lewej polowie
            if (e.Location.X < panel1.Width / 2)
                ZaznaczonyPracownik.Lewo = true; // Zmana wlasciwosci Lewo na True
            else // po prawej polowie
                ZaznaczonyPracownik.Prawo = true;// Zmana wlasciwosci Prawo na True
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Jezeli zaden pracownik nie jest zaznaczony, przerwij
            if (ZaznaczonyPracownik == null)
                return;

            ZaznaczonyPracownik.Lewo = false;
            ZaznaczonyPracownik.Prawo = false;
        }
    }
}