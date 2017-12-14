using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class Ordinacija : Odjel
    {
        int brojZauzeca = 0;
        int brojSobe;

        public int BrojZauzeca
        {
            get
            {
                return brojZauzeca;
            }

        }
        public void zauzmiMjestoURedu()
        {
            brojZauzeca++;
        }

        public void oslobodiMjestoURedu()
        {
            if (brojZauzeca > 0)
                brojZauzeca--;
            else throw new ArgumentOutOfRangeException("Nema reda za cekanje, i ne moze se vise isprazniti.");
        }

        public int BrojSobe
        {
            get
            {
                return brojSobe;
            }

            set
            {
                brojSobe = value;
            }
        }
    }
}
