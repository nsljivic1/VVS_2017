using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class MedicinskaOprema
    {
        bool uKvaru;

        DateTime vrijemeAktiviranja;
        DateTime vrijemeDeaktiviranja;
        TimeSpan vrijemeMaksimalnogKoristenja;
        TimeSpan vrijemeMinimalnogNekoristenja;

        public bool UKvaru
        {
            get
            {
                return uKvaru;
            }

            set
            {
                uKvaru = value;
            }
        }

        public void aktivirajAparat()
        {
            vrijemeAktiviranja = DateTime.Now;
        }
        public void deaktivirajAparat()
        {
            vrijemeAktiviranja = DateTime.Now;

        }
        public bool smijeLiSeAktivirati()
        {
            if (DateTime.Now - vrijemeDeaktiviranja < vrijemeMinimalnogNekoristenja)
                return false;
            return true;
        }

        public bool jeLiVrijemeDeaktivacije()
        {
            if (DateTime.Now - vrijemeAktiviranja < vrijemeMaksimalnogKoristenja)
                return false;
            return true;
        }
    }
}
