using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiPP_DG
{
    public delegate void Wiadomosc(string msg); // deklaracja delegata

    public class Gracz
    {
        // zmienne, wlasciwosci
        private bool skok = false;
        public bool Skok
        {
            get { return skok; }
            set
            {
                skok = value;
                // przy ustawieniu skoku, ustawianie predkosci spadania / grawitacji
                if (value)
                    PredkoscSpadania = -5;
                else
                    PredkoscSpadania = 5;
            }
        }
        int PredkoscSpadania = 5;
        PictureBox gracz; // referencja do obiektu

        private float wynik = 0;
        public float Wynik
        {
            get { return wynik; }
            set
            {
                wynik = value;
                WiadomoscHandler("Wynik: " + wynik); // wywolanie zdarzenia / eventu
            }
        }

        public event Wiadomosc WiadomoscHandler; // zdarzenie

        // konstruktor
        public Gracz(PictureBox _gracz)
        {
            gracz = _gracz;
        }
        
        // metoda ruchu obiektu, przyjmujaca kolekcje obiektow kolizyjnych
        public bool Ruch(List<PictureBox> obiekty)
        {
            // spadanie
            gracz.Top += PredkoscSpadania;

            // sprawdzenie kolizji
            foreach (PictureBox obiekt in obiekty)
            {
                if (gracz.Bounds.IntersectsWith(obiekt.Bounds))
                    return true; // jest kolizja - zwroc prawde
            }
            return false; // nie ma kolizji - zwroc falsz
        }
    }
}