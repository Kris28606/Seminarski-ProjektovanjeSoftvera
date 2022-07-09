using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public Mesto Mesto { get; set; }
        public List<Kurs> ListaKurseva { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
