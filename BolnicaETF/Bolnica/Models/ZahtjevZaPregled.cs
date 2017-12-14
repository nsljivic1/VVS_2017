using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class ZahtjevZaPregled
    {
        Pacijent pacijent;
        Ordinacija ordinacija;
        DateTime vrijemePodnosenja;

        internal Ordinacija Ordinacija
        {
            get
            {
                return ordinacija;
            }

            set
            {
                ordinacija = value;
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

        public DateTime VrijemePodnosenja
        {
            get
            {
                return vrijemePodnosenja;
            }

            set
            {
                vrijemePodnosenja = value;
            }
        }
    }
}
