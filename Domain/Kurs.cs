using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Kurs
    {
        public int KursId { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int Trajanje { get; set; }
        public List<Korisnik> ListaKorisnika { get; set; }
        public List<Predavac> ListaPredavaca { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
