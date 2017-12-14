using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class Karton
    {
        Pacijent pacijent;
        string porodicneBolesti;
        string krvnaGrupa;
        List<Pregled> pregledi;
        List<Nalaz> nalazi;

        public Pacijent Pacijent { get => pacijent; set => pacijent = value; }
        public string PorodicneBolesti { get => porodicneBolesti; set => porodicneBolesti = value; }
        public string KrvnaGrupa { get => krvnaGrupa; set => krvnaGrupa = value; }
        internal List<Pregled> Pregledi { get => pregledi; set => pregledi = value; }
        internal List<Nalaz> Nalazi { get => nalazi; set => nalazi = value; }
    }
}
