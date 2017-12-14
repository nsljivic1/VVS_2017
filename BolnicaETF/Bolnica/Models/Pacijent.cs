using Bolnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica
{
    public class Pacijent : Osoba
    {
        string adresaStanovanja;
        string bracnoStanje;
        DateTime datumRodjenja;
        bool preminuo;
        Anamneza anamneza;
        Karton karton;

        public string AdresaStanovanja
        {
            get
            {
                return adresaStanovanja;
            }

            set
            {
                adresaStanovanja = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public bool Preminuo
        {
            get
            {
                return preminuo;
            }

            set
            {
                preminuo = value;
            }
        }

        internal Anamneza Anamneza
        {
            get
            {
                return anamneza;
            }

            set
            {
                anamneza = value;
            }
        }

        internal Karton Karton
        {
            get
            {
                return karton;
            }

            set
            {
                karton = value;
            }
        }
    }
}
