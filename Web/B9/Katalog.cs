using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B9
{
    public class Katalog
    {
        private string izvodjac, naziv_albuma, zanr, godina_izdanja, izdavacka_kuca, slika_omota;


        public string Slika_omota
        {
            get
            {
                return slika_omota;
            }
        }
        public string Izvodjac
        {
            get
            {
                return izvodjac;
            }
        }

        public string Naziv_albuma
        {
            get
            {
                return naziv_albuma;
            }
        }

        public string Zanr
        {
            get
            {
                return zanr;
            }
        }

        public string Godina_izdanja
        {
            get
            {
                return godina_izdanja;
            }
        }

        public string Izdavacka_kuca
        {
            get
            {
                return izdavacka_kuca;
            }
        }


        public void Load(string s)
        {
            string[] podaci = s.Split('|');
            izvodjac = podaci[0];
            naziv_albuma = podaci[1];
            zanr = podaci[2];
            godina_izdanja = podaci[3];
            izdavacka_kuca = podaci[4];
            slika_omota = podaci[5];
        }
    }
}