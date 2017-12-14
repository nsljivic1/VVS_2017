using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class Racun
    {
        DateTime datumIzdavanja;
        double postotakPopusta=0;
        double punaCijena;
        double ukupnaCijena;
        Pacijent pacijent;
       
        public double izracunajPunuCijenu(List<Usluga> usluge)
        {
            double sumaCijena = 0;
            foreach (Usluga usl in usluge)
                sumaCijena += usl.CijenaUsluge;
            punaCijena = sumaCijena;
            return sumaCijena;
        }
        public double obracunajPopustNaPosjetePacijenata(List<PrijavnicaPacijenta> prijavnice)
        {
            int brojac = 0;
            foreach (PrijavnicaPacijenta pr in prijavnice)
                if (pr.Pacijent == pacijent)
                    brojac++;
            if (brojac >= 3)
                return 0.1;
            else return 0;
        }
        public double obracunajPopustNaMladostPacijenta()
        {
            //Za placanje osoba mladjih od 12god
            if (DateTime.Now.Year - pacijent.DatumRodjenja.Year <= 12)
                return 0.5;
            else return 0;
        }


        public DateTime DatumIzdavanja
        {
            get
            {
                return datumIzdavanja;
            }

            set
            {
                datumIzdavanja = value;
            }
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
    }
}
