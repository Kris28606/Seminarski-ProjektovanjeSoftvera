using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SeminarskiPS;Integrated Security=True;");
        }
        public List<Kurs> VratiSveKurseveZaKorisnika(Korisnik korisnik)
        {
            List<Kurs> kursevi = new List<Kurs>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Kurs k join KursKorisnik kk on (k.KursId=kk.KursId) where kk.KorisnikId={korisnik.KorisnikId}";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kurs k = new Kurs
                {
                    KursId = (int)reader[0],
                    Naziv = reader[1].ToString(),
                    DatumPocetka = DateTime.Parse(reader[3].ToString()),
                    Cena = (double)reader[2],
                    Trajanje = (int)reader[4]
                };

                kursevi.Add(k);

            }
            reader.Close();

            return kursevi;
        }
        public void SacuvajKursPredavac(Kurs k, int idPredavac)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"insert into KursPredavac values (@KursId, @PredavacId)";

            command.Parameters.AddWithValue("@KursId", k.KursId);
            command.Parameters.AddWithValue("@PredavacId", idPredavac);

            command.ExecuteNonQuery();
        }

        public void SacuvajKursKorisnik(Kurs kurs, int idKorisnika)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"insert into KursKorisnik values (@KursId, @KorisnikId)";

            command.Parameters.AddWithValue("@KursId", kurs.KursId);
            command.Parameters.AddWithValue("@KorisnikId", idKorisnika);

            command.ExecuteNonQuery();
        }
        public List<Kurs> VratiSveKurseveZaPredavaca(Predavac p)
        {
            List<Kurs> kursevi = new List<Kurs>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Kurs k join KursPredavac kp on (k.KursId=kp.KursId) where kp.PredavacId={p.PredavacId}";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kurs k = new Kurs
                {
                    KursId = (int)reader[0],
                    Naziv = reader[1].ToString(),
                    DatumPocetka = DateTime.Parse(reader[3].ToString()),
                    Cena = (double)reader[2],
                    Trajanje = (int)reader[4]
                };

                kursevi.Add(k);

            }
            reader.Close();

            return kursevi;
        }
        public SqlCommand KreirajKomandu()
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            return command;
        }
        public void ObrisiKurseveZaPredavaca(Predavac p)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"delete from KursPredavac where PredavacId={p.PredavacId}";

            command.ExecuteNonQuery();
        }

        #region
        public List<Mesto> VratiSvaMesta()
        {
            List<Mesto> mesta = new List<Mesto>();
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "select * from Mesto";

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Mesto m = new Mesto
                {
                    MestoId = (int)reader[0],
                    Naziv = (string)reader[1],
                    PTT = Int32.Parse(reader[2].ToString())
                };
                mesta.Add(m);
            }
            reader.Close();
            return mesta;
        }

        

        public List<Faktura> VratiSveFakture()
        {
            List<Faktura> fakture = new List<Faktura>();
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "select * from Faktura f join Korisnik k on (f.KorisnikId=k.KorisnikId)";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Faktura faktura = new Faktura
                {
                    FakturaId = (int)reader[0],
                    Datum = DateTime.Parse(reader[1].ToString()),
                    UkupnaCena = (double)reader[2],
                    NacinPlacanja = (NacinPlacanja)reader[3],
                    Stornirana = (bool)reader[4],
                    Korisnik = new Korisnik
                    {
                        KorisnikId = (int)reader[5],
                        Ime = (string)reader[7],
                        Prezime = (string)reader[8],
                        Kontakt = (string)reader[9],
                        Adresa = (string)reader[10]
                    }
                };
                fakture.Add(faktura);

            }
            reader.Close();
            return fakture;
        }

        

        public void IzmeniPredavaca(Predavac p)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"update Predavac set Ime=@Ime, Prezime= @Prezime, Pol= @Pol, DatumRodjenja=@DatumRodjenja where PredavacId={p.PredavacId}";

            command.Parameters.AddWithValue("@Ime", p.Ime);
            command.Parameters.AddWithValue("@Prezime", p.Prezime);
            command.Parameters.AddWithValue("@Pol", p.Pol);
            command.Parameters.AddWithValue("@DatumRodjenja", p.DatumRodjenja);

            command.ExecuteNonQuery();
        }

        public List<Predavac> NadjiPredavace(string kriterijum)
        {
            List<Predavac> predavaci = new List<Predavac>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Predavac where (Ime like '%{kriterijum}%')";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Predavac p = new Predavac
                {
                    PredavacId = (int)reader[0],
                    Ime = reader[1].ToString(),
                    Prezime = reader[2].ToString(),
                    Pol = (Pol)reader[3],
                    DatumRodjenja = DateTime.Parse(reader[4].ToString()),

                };

                predavaci.Add(p);

            }
            reader.Close();
            return predavaci;
        }

        

        public void ObrisiKorisnika(Korisnik korisnik)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"delete from Korisnik where KorisnikId={korisnik.KorisnikId}";

            command.ExecuteNonQuery();
        }

        public List<Korisnik> NadjiKorisnike(string kriterijum)
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Korisnik k join Mesto m on (k.MestoId=m.MestoId) where (k.Ime like '%{kriterijum}%')";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Korisnik korisnik = new Korisnik
                {
                    KorisnikId = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    Kontakt = (string)reader[3],
                    Adresa = (string)reader[4],
                    Mesto = new Mesto
                    {
                        MestoId = (int)reader[5],
                        Naziv = (string)reader[7],
                        PTT = Int32.Parse(reader[8].ToString())
                    }
                };
                korisnici.Add(korisnik);

            }
            reader.Close();
            return korisnici;
        }

        public void StornirajFakturu(Faktura faktura)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"update Faktura set Stornirana=@Stornirana where FakturaId={faktura.FakturaId}";
            command.Parameters.AddWithValue("@Stornirana", faktura.Stornirana);

            command.ExecuteNonQuery();
        }

        public List<Faktura> NadjiFakture(string kriterijum)
        {
            List<Faktura> fakture = new List<Faktura>();
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Faktura f join Korisnik k on (f.KorisnikId=k.KorisnikId) where (k.Ime like '%{kriterijum}%')";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Faktura faktura = new Faktura
                {
                    FakturaId = (int)reader[0],
                    Datum = DateTime.Parse(reader[1].ToString()),
                    UkupnaCena = (double)reader[2],
                    NacinPlacanja = (NacinPlacanja)reader[3],
                    Stornirana = (bool)reader[4],
                    Korisnik = new Korisnik
                    {
                        KorisnikId = (int)reader[5],
                        Ime = (string)reader[7],
                        Prezime = (string)reader[8],
                        Kontakt = (string)reader[9],
                        Adresa = (string)reader[10]
                    }
                };
                fakture.Add(faktura);

            }
            reader.Close();
            return fakture;
        }

        

        public int SacuvajKorisnika(Korisnik k)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"insert into Korisnik output inserted.KorisnikId values (@Ime, @Prezime, @Kontakt, @Adresa, @MestoId)";

            command.Parameters.AddWithValue("@Ime", k.Ime);
            command.Parameters.AddWithValue("@Prezime", k.Prezime);
            command.Parameters.AddWithValue("@Kontakt", k.Kontakt);
            command.Parameters.AddWithValue("@Adresa", k.Adresa);
            command.Parameters.AddWithValue("@MestoId", k.Mesto.MestoId);



            return (int)command.ExecuteScalar();
        }

        public List<Korisnik> VratiSveKorisnike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "select * from Korisnik k join Mesto m on (k.MestoId=m.MestoId)";

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Korisnik korisnik = new Korisnik
                {
                    KorisnikId = (int)reader[0],
                    Ime=(string)reader[1],
                    Prezime = (string)reader[2],
                    Kontakt = (string)reader[3],
                    Adresa = (string)reader[4],
                    Mesto=new Mesto
                    {
                        MestoId = (int)reader[5],
                        Naziv = (string)reader[7],
                        PTT = Int32.Parse(reader[8].ToString())
                    }
                };
                korisnici.Add(korisnik);

            }
            reader.Close();
            return korisnici;
        }

        

        public List<Kurs> NadjiKurseve(string kriterijum)
        {
            List<Kurs> kursevi = new List<Kurs>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from Kurs where (Naziv like '%{kriterijum}%')";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kurs k = new Kurs
                {
                    KursId = (int)reader[0],
                    Naziv = reader[1].ToString(),
                    DatumPocetka = DateTime.Parse(reader[3].ToString()),
                    Cena = (double)reader[2],
                    Trajanje = (int)reader[4]
                };

                kursevi.Add(k);

            }
            reader.Close();

            return kursevi;
        }

        public int SacuvajPredavaca(Predavac p)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"insert into Predavac output inserted.PredavacId values (@Ime, @Prezime, @Pol, @DatumRodjenja)";

            command.Parameters.AddWithValue("@Ime", p.Ime);
            command.Parameters.AddWithValue("@Prezime", p.Prezime);
            command.Parameters.AddWithValue("@Pol", p.Pol);
            command.Parameters.AddWithValue("@DatumRodjenja", p.DatumRodjenja);

            return (int)command.ExecuteScalar();
        }

        public int SacuvajFakturu(Faktura faktura)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction=transaction;
            command.CommandText = $"insert into Faktura output inserted.FakturaId values (@Datum, @UkupnaCena, @NacinPlacanja, @Stornirana, @KorisnikId)";

            command.Parameters.AddWithValue("@Datum", faktura.Datum);
            command.Parameters.AddWithValue("@UkupnaCena", faktura.UkupnaCena);
            command.Parameters.AddWithValue("@NacinPlacanja", faktura.NacinPlacanja);
            command.Parameters.AddWithValue("@Stornirana", faktura.Stornirana);
            command.Parameters.AddWithValue("@KorisnikId", faktura.Korisnik.KorisnikId);



            return (int)command.ExecuteScalar();
        }

        public List<Predavac> VratiSvePredavace()
        {
            List<Predavac> predavaci = new List<Predavac>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "select * from Predavac";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Predavac p = new Predavac
                {
                    PredavacId = (int)reader[0],
                    Ime = reader[1].ToString(),
                    Prezime = reader[2].ToString(),
                    Pol = (Pol)reader[3],
                    DatumRodjenja = DateTime.Parse(reader[4].ToString()),
                    
                };

                predavaci.Add(p);

            }
            reader.Close();
            return predavaci;
        }

        public void SacuvajStavkuFakture(StavkaFakture sf)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"insert into StavkaFakture values (@FakturaId, @RedniBroj, @VrednostStavke, @KursId)";

            command.Parameters.AddWithValue("@FakturaId", sf.FakturaId);
            command.Parameters.AddWithValue("@RedniBroj", sf.RedniBroj);
            command.Parameters.AddWithValue("@VrednostStavke", sf.VrednostStavke);
            command.Parameters.AddWithValue("@KursId", sf.Kurs.KursId);


            command.ExecuteNonQuery();
        }

        public void DodajKurs(Kurs k)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "insert into Kurs values (@Naziv, @Cena, @DatumPocetka, @Trajanje)";

            command.Parameters.AddWithValue("@Naziv", k.Naziv);
            command.Parameters.AddWithValue("@Cena", k.Cena);
            command.Parameters.AddWithValue("@DatumPocetka", k.DatumPocetka);
            command.Parameters.AddWithValue("@Trajanje", k.Trajanje);

            command.ExecuteNonQuery();
        }

        public void IzmeniKurs(Kurs k)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"update Kurs set Naziv=@Naziv, Cena= @Cena, DatumPocetka= @DatumPocetka, Trajanje=@Trajanje where KursId={k.KursId}";

            command.Parameters.AddWithValue("@Naziv", k.Naziv);
            command.Parameters.AddWithValue("@Cena", k.Cena);
            command.Parameters.AddWithValue("@DatumPocetka", k.DatumPocetka);
            command.Parameters.AddWithValue("@Trajanje", k.Trajanje);

            command.ExecuteNonQuery();
        }

        public List<Kurs> VratiSveKurseve()
        {
            List<Kurs> kursevi = new List<Kurs>();

            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = "select * from Kurs";

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Kurs k = new Kurs
                {
                    KursId = (int)reader[0],
                    Naziv = reader[1].ToString(),
                    DatumPocetka = DateTime.Parse(reader[3].ToString()),
                    Cena = (double)reader[2],
                    Trajanje = (int)reader[4]
                };

                kursevi.Add(k);

            }
            reader.Close();

            return kursevi;
        }
        #endregion
        
        public void OpenConnection()
        {
            connection.Open();
        }

        public User LogIn(User user)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.Transaction = transaction;
            command.CommandText = $"select * from [User] where Email='{user.Email}' and Sifra='{user.Sifra}'";

            SqlDataReader reader = command.ExecuteReader();

            if(!reader.Read())
            {
                return null;
            }

            user = new User
            {
                UserId = reader.GetInt32(0),
                Ime = reader[1].ToString(),
                Prezime = reader[2].ToString(),
                Email = reader[3].ToString(),
                Sifra = reader[4].ToString()
            };
            reader.Close();

            return user;
        }

        public void CloseConnection()
        {
            if(connection != null & connection.State!=System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        
        public void BeginTransakcion()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            if(transaction!=null)
            {
                transaction.Commit();
            }
        }
        public void Rollback()
        {
            if(transaction!=null )
            {
                transaction.Rollback();
            }
        }
    
        
    
    }
}
