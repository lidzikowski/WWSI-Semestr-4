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
    // Deklaracja delegata
    public delegate void DodajUcznia(Uczen uczen);

    public partial class NowyUczen : Form
    {
        public NowyUczen()
        {
            InitializeComponent();

            // Przypisanie slownikow do comboBox'ow
            comboBoxPlec.DataSource = Enum.GetValues(typeof(Plec));
            comboBoxKlasa.DataSource = Enum.GetValues(typeof(Klasa));
        }

        // Deklaracja zdarzenia
        public event DodajUcznia OnDodajUcznia;

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // Pobranie wpisanych informacji do textBox'ow
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;

            // Pobranie danych z comboBox'ow
            Plec plec = (Plec)Enum.Parse(typeof(Plec), comboBoxPlec.SelectedValue.ToString());
            Klasa klasa = (Klasa)Enum.Parse(typeof(Klasa), comboBoxKlasa.SelectedValue.ToString());

            // Stworznie obiektu ucznia z wyzej wpisanych informacji
            Uczen uczen = new Uczen(imie, nazwisko, plec, klasa);

            // Wywolanie zdarzenia i przekazanie mu stworzonego ucznia
            OnDodajUcznia(uczen);

            // Zamkniecie okna dodawania
            Close();
        }
    }
}
