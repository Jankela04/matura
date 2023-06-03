using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonski_Imenik
{
    public partial class TelImenik
    {
        private string id, ime, prezime, adresa, mesto, broj, email;

        public string ID
        { get { return id; } }


        public string Ime
        { get { return ime; } }

        public string Prezime
        { get { return prezime; } }

        public string Adresa
        { get { return adresa; } }

        public string Mesto
        { get { return mesto; } }

        public string Broj
        { get { return broj; } }

        public string Email
        { get { return email; } }


        public void metoda(string s)
        {
            string[] podaci = s.Split('|');
            id = podaci[0];
            ime = podaci[1];
            prezime = podaci[2];
            adresa = podaci[3];
            mesto = podaci[4];
            broj = podaci[5];
            email = podaci[6];

        }
    }
}