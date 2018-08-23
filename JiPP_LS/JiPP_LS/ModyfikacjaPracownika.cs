using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_LS
{
    // Deklaracja wlasnego typu zdarzenia -> delegata
    public delegate void DodajPracownika(Pracownik pracownik);
    public delegate void OdswierzPracownikow();

    // Klasa dodajPracownika
    public partial class ModyfikacjaPracownika : Form
    {
        // Deklaracja zdarzenia klasy
        public event DodajPracownika OnDodajPracownika;
        public event OdswierzPracownikow OnOdswierzPracownikow;

        public ModyfikacjaPracownika()
        {
            InitializeComponent();
        }

        private void buttonLosujWiek_Click(object sender, EventArgs e)
        {
            // Stworzenie obiektu losowosci
            Random random = new Random();

            // Wykorzystanie obiektu losowosci do wygenerowania liczby, zamienienia jej na ciag znakow oraz wpisanie jej do wlasciwosci Text obiektu TextBox
            textBoxWiek.Text = random.Next(0, 50).ToString();
        }

        private void buttonOperacjaDodaj_Click(object sender, EventArgs e)
        {
            // Pobranie wpisanego imienia z pola Imie w formularzu
            string imie = textBoxImie.Text;

            // Pobranie wpisanego nazwiska z pola Nazwisko w formularzu
            string nazwisko = textBoxNazwisko.Text;

            // Pobranie wpisanego wieku z pola Wiek w formularzu
            int wiek = int.Parse(textBoxWiek.Text);

            // Stworzenie obiektu na podstawie pobranych danych z formularza
            Pracownik pracownik = new Pracownik(imie, nazwisko, wiek);

            // Wywolanie zdarzenia i przekazanie do niego stworzonego obiektu
            OnDodajPracownika(pracownik);

            // Zamkniecie formularza
            this.Close();
        }

        private Pracownik pracownik;
        private void buttonOperacjaEdytuj_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy obiekt pracownika istnieje
            if (pracownik == null)
                return;

            // Przypisanie nowego imienia do obiektu pracownika
            pracownik.Imie = textBoxImie.Text;

            // Przypisanie nowego nazwiska do obiektu pracownika
            pracownik.Nazwisko = textBoxNazwisko.Text;

            // Przypisanie nowego wieku do obiektu pracownika
            pracownik.Wiek = double.Parse(textBoxWiek.Text);

            // Wywolanie zdarzenia
            OnOdswierzPracownikow();

            // Zamkniecie formularza
            this.Close();
        }

        /// <summary>
        /// Przystosowanie okna modyfikacji pracownika do wykonywanej operacji
        /// </summary>
        /// <param name="operacja">Operacja okna</param>
        /// <param name="pracownik">Obiekt Pracownika.</param>
        public void TrybOkna(Operacja operacja, Pracownik pracownik = null)
        {
            switch(operacja)
            {
                case Operacja.Dodaj:
                    // Ustawienie tytulu okna
                    Text = "Dodawanie pracownika";

                    // Przypisanie funkcji dodawania pracownika do przycisku operacji
                    buttonOperacja.Click += buttonOperacjaDodaj_Click;

                    // Ustawienie nazwy przycisku operacyjnego
                    buttonOperacja.Text = "Dodaj pracownika";
                    break;
                case Operacja.Edytuj:
                    // Ustawienie tytulu okna
                    Text = "Edycja pracownika";

                    // Przypisanie funkcji edycji pracownika do przycisku operacji
                    buttonOperacja.Click += buttonOperacjaEdytuj_Click;

                    // Ustawienie wlasciwosci pracownika w formularzu do edycji
                    textBoxImie.Text = pracownik.Imie;
                    textBoxNazwisko.Text = pracownik.Nazwisko;
                    textBoxWiek.Text = pracownik.Wiek.ToString();

                    // Ustawienie nazwy przycisku operacyjnego
                    buttonOperacja.Text = "Edytuj pracownika";

                    // Przypisanie pracownika z parametru do obiektu tej klasy
                    this.pracownik = pracownik;
                    break;
            }
        }
    }
}
