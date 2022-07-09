using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.Session
{
    public class Session
    {
        private static Session instance;

        private Session()
        {

        }

        public static Session Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        public User TrenutnoPrijavljeni { get; set; }
    }
}
