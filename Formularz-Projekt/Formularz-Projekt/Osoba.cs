using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz_Projekt
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int numerTelefonu;
        private string Email;
        private string zawód;
        private string typZawodu;
        private string chorobyAlerg;
        private int wiek;
        private float masaCiała;
        private float wzrost;
        private float BMI;
        private float ObwBioder;
        private float ObwTalii;

        public Osoba(string imie, string nazwisko, int wiek, float masaCiała, float wzrost)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.masaCiała = masaCiała;
            this.wzrost = wzrost;
        }

    }
}
