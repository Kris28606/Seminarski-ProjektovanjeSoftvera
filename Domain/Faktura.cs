using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Faktura
    {
        public int FakturaId { get; set; }
        public DateTime Datum { get; set; }
        public double UkupnaCena { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
        public bool Stornirana { get; set; }
        public Korisnik Korisnik { get; set; }
        public List<StavkaFakture> Stavke { get; set; }
    }
}
