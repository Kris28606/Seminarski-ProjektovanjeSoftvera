using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Odgovor
    {
        public string Poruka { get; set; }
        public object OdgovorObjekat { get; set; }
        public bool UspesnaOperacija { get; set; } = true;
    }
}
