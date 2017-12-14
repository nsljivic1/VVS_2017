using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class PrijavnicaPacijenta
    {
        DateTime datumprijave;
        Pacijent pacijent;
        List<ZahtjevZaPregled> zahtjevi;
        MedicinskiTehnicar medicinskiTehnicar;
        DateTime datumOdjave;
        public PrijavnicaPacijenta(Pacijent p, List<ZahtjevZaPregled> listaZahtjeva, MedicinskiTehnicar medTehnicar)
        {
            pacijent = p;
            medicinskiTehnicar = medTehnicar;
            zahtjevi = listaZahtjeva;
            datum = DateTime.Now;
        }

        public List<Ordinacija> listaOrdinacijaZaPosjetiti(List<Ordinacija> sveOrdinacije)
        {
            List < Ordinacija > ordinacijeZaPosjetiti= new List<Ordinacija>();
            foreach(Ordinacija o in sveOrdinacije)
            {
                foreach ( ZahtjevZaPregled z in zahtjevi)
                {
                    if(o == z.Ordinacija)
                    {
                        ordinacijeZaPosjetiti.Add(z.Ordinacija);
                    }
                }
            }
            ordinacijeZaPosjetiti.OrderBy(x => x.BrojZauzeca);
            return ordinacijeZaPosjetiti;
        }

        public Pacijent Pacijent
        {
            get
            {
                return pacijent;
            }

            set
            {
                pacijent = value;
            }
        }

        internal List<ZahtjevZaPregled> Zahtjevi
        {
            get
            {
                return zahtjevi;
            }

            set
            {
                zahtjevi = value;
            }
        }

        internal MedicinskiTehnicar MedicinskiTehnicar
        {
            get
            {
                return medicinskiTehnicar;
            }

            set
            {
                medicinskiTehnicar = value;
            }
        }

    }
}
