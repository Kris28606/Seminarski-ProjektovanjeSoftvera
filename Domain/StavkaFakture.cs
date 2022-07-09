using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaFakture
    {
        public int FakturaId { get; set; }
        public int RedniBroj { get; set; }
        public double VrednostStavke { get; set; }
        public Kurs Kurs { get; set; }

    }
}
