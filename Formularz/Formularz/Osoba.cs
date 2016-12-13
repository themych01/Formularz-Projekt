using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz_Projekt
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int numerTelefonu;
        protected string Email;
        protected string zawód;
        protected string typZawodu;
        protected int wiek;
        protected double masaCiała;
        protected double wzrost;
        protected double BMI;
        protected double ObwBioder;
        protected double ObwTalii;

        public Osoba(string imie, string nazwisko, int wiek, double masaCiała, double wzrost, int numerTelefonu, string Email, string zawód, string typZawodu, double ObwBioder, double ObwTalii)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.masaCiała = masaCiała;
            this.wzrost = wzrost;
            this.numerTelefonu = numerTelefonu;
            this.Email = Email;
            this.zawód = zawód;
            this.typZawodu = typZawodu;
            this.ObwBioder = ObwBioder;
            this.ObwTalii = ObwTalii;

        }
        public void WyliczBMI()
        {
            BMI = masaCiała / (wzrost * wzrost);
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Imie : {0}", imie);
            Console.WriteLine("Nazwisko : {0}", nazwisko);
            Console.WriteLine("Wiek : {0}", wiek);
            Console.WriteLine("Masa Ciała : {0}", masaCiała);
            Console.WriteLine("Wzrost : {0}", wzrost);
            Console.WriteLine("BMI : {0}", BMI);
            Console.WriteLine("Numer Telefonu : {0}", numerTelefonu);
            Console.WriteLine("Zawód = {0}", zawód);
            Console.WriteLine("Typ Zawodu : {0}", typZawodu);
            Console.WriteLine("Obwód Bioder : {0}", ObwBioder);
            Console.WriteLine("Obwód Talii : {0}", ObwTalii);
            Console.ReadKey();
        }

    }
}
