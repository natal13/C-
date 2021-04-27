using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class Osoba
    {

        public String nazwisko { get; set; }
        public String imie { get; set; }
        public String ulica { get; set; }
        public int numer { get; set; }
        public String kod { get; set; }
        public String miasto { get; set; }


        //konstruktor bezargumentowy 
        public Osoba()
        {
            nazwisko = "brak";
            imie = "brak";
            ulica = "brak";
            numer = 0;
            kod = "brak";
            miasto = "brak";

        }

        //jedno 
        public Osoba(string nazwisko_arg)
        {
            nazwisko = nazwisko_arg;
        }

        //dwu 
        public Osoba(string nazwisko_arg, string imie_arg)
        {
            nazwisko = nazwisko_arg;
            imie = imie_arg;
        }

        //trzy
        public Osoba(string nazwisko_arg, string imie_arg,
            string ulica_arg)
        {
            nazwisko = nazwisko_arg;
            imie = imie_arg;
            ulica = ulica_arg;
        }

        //
        public Osoba(string nazwisko_arg, string imie_arg,
          string ulica_arg, int numer_arg)
        {
            nazwisko = nazwisko_arg;
            imie = imie_arg;
            ulica = ulica_arg;
            numer = numer_arg;
        }

        //
        public Osoba(string nazwisko_arg, string imie_arg,
          string ulica_arg, int numer_arg, string miasto_arg)
        {
            nazwisko = nazwisko_arg;
            imie = imie_arg;
            ulica = ulica_arg;
            numer = numer_arg;
            miasto = miasto_arg;
        }

        //
        public Osoba(string nazwisko_arg, string imie_arg,
          string ulica_arg, int numer_arg, string miasto_arg,
          string kod_arg)
        {
            nazwisko = nazwisko_arg;
            imie = imie_arg;
            ulica = ulica_arg;
            numer = numer_arg;
            miasto = miasto_arg;
            kod = kod_arg;
        }


    }
}
