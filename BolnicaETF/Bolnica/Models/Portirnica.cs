using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class Portirnica : Odjel
    {
        private MedicinskiTehnicar mt;
        List<Pacijent> pacijenti;
        List<Karton> kartoni;
        List<Ordinacija> ordinacije;
        List<ZahtjevZaPregled> zahtjevizapregled;

        internal MedicinskiTehnicar Mt { get => mt; set => mt = value; }

        public void registrujPacijenta(Pacijent pacijent)
        {
            
            pacijenti.Add(pacijent);

        }

        public void dodajZahtjevzaPregled(ZahtjevZaPregled z)
        {
            zahtjevizapregled.Add(z);
        }

        public void prijaviPacijenta(Pacijent p)
        {

        }
        public void odjaviPacijenta(Pacijent p)
        {

        }

        public List<Ordinacija> uputiPacijenta(Pacijent pacijent, List<Pregled> pregledi)
        {
            List<Ordinacija> ordinacije = new List<Ordinacija>();

            return ordinacije;
        }
    }
}
