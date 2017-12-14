using Bolnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica
{
    class Pregled : Usluga
    {
        DateTime datumPregleda;
        Pacijent pacijent;
        Doktor doktor;
        string zakljucak;
        List<Terapija> terapije;
        List<Uputnica> uputnice;
    }
}
