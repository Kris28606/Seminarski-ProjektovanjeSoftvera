using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerCommunication
{
    public class Communication
    {
        private Socket soket;
        private static Communication instance;
        private CommunicationHelper helper;

        private Communication()
        {
        }

        public static Communication Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        public void Connect()
        {
            if (soket == null || !soket.Connected)
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // da bih mogla da se povezujem sa serverom koliko god puta ja hocu,
                // jer ono sto je disposovano ne moze ponovo da se koristi
                soket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(soket);
            }
        }

        public void PosaljiZahtevBezRezultata(Operacija operacija, object zahtevObjekat=null)
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            VratiRezultat();
        }
        
        public Rezultat PosaljiZahtevVratiRezultat<Rezultat>(Operacija operacija, object zahtevObjekat=null) where Rezultat : class
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            return VratiRezultat<Rezultat>();
        }

        private void VratiRezultat()
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if(!odgovor.UspesnaOperacija)
            {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }

        private Rezultat VratiRezultat<Rezultat>() where Rezultat : class
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (odgovor.UspesnaOperacija)
            {
                return (Rezultat)odgovor.OdgovorObjekat;
            }
            else {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }

        private void PosaljiZahtev(Operacija operacija, object objekat=null)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = operacija,
                    ZahtevObjekat = objekat
                };
                helper.Posalji(z);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Operacija=Operacija.Kraj };

                helper.Posalji(zahtev);
                soket.Shutdown(SocketShutdown.Both);
                soket.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
