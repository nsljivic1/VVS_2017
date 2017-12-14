using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Models
{
    class Terapija
    {
        Pacijent pacijent;
        Doktor doktor;

        string opisTerapije;
        DateTime datumPropisanja;
        DateTime datumKrajaTerapije;
        bool kratkorocna;
        bool aktivna;
    }
}
