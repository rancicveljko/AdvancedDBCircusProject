﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CirkusApp1.DTOs.Basics;
using CirkusApp1.Entiteti;
using NHibernate;

namespace CirkusApp1.DTOManagers
{
    public class DTOManager
    {
        #region MestoBoravka 
        //proveriti posle ubacivanja CRUD operacija za cirkusku predstavu jel sve funkcionise
        public static List<MestoBoravkaBasic> vratiSvaMestaBoravka()
        {
            List<MestoBoravkaBasic> mesta = new List<MestoBoravkaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<MestoBoravka> svaMesta = from o in s.Query<MestoBoravka>()
                                                     select o;

                foreach (MestoBoravka mb in svaMesta)
                {
                    var mestoBoravka = new MestoBoravkaBasic(mb);
                    mestoBoravka.Predstave = mb.Predstave.Select(mb => new CirkuskaPredstavaBasic(mb)).ToList();
                    //mesta.Add(new MestoBoravkaBasic(mb.IdMesta, mb.Grad, mb.Drzava, mb.Opis, mb.VremeUGradu));
                    mesta.Add(mestoBoravka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mesta;
        }
        public static void dodajMestoBoravka(MestoBoravkaBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MestoBoravka n = new MestoBoravka();

                n.Grad = mb.Grad;
                n.Drzava = mb.Drzava;
                n.Opis = mb.Opis;
                n.VremeUGradu = mb.Vreme_u_gradu;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static MestoBoravkaBasic azurirajMestoBoravka(MestoBoravkaBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MestoBoravka n = s.Load<MestoBoravka>(mb.IdMesta);

                n.Grad = mb.Grad;
                n.Drzava = mb.Drzava;
                n.Opis = mb.Opis;
                n.VremeUGradu = mb.Vreme_u_gradu;

                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static MestoBoravkaBasic vratiMestoBoravka(int id)
        {
            MestoBoravkaBasic mb = new MestoBoravkaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MestoBoravka mesto = s.Load<MestoBoravka>(id);
                mb = new MestoBoravkaBasic(mesto.IdMesta, mesto.Grad, mesto.Drzava, mesto.Opis, mesto.VremeUGradu);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static void obrisiMestoBoravka(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MestoBoravka mesto = s.Load<MestoBoravka>(id);

                s.Delete(mesto);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion
        #region NastupnaTacka
        public static List<NastupnaTackaBasic> vratiSveNastupneTacke()
        {
            List<NastupnaTackaBasic> tacke = new List<NastupnaTackaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NastupnaTacka> sveTacke = from o in s.Query<NastupnaTacka>()
                                                      select o;

                foreach (NastupnaTacka nt in sveTacke)
                {
                    tacke.Add(new NastupnaTackaBasic(nt.IdTacke, nt.Ime, nt.Tip, nt.MinGodina, nt.OpasniEfekti));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return tacke;
        }
        public static void dodajNastupnuTacku(NastupnaTackaBasic nt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n = new NastupnaTacka();
                CirkuskaPredstava predstava = s.Load<CirkuskaPredstava>(nt.Predstava.IdPredstave);
                n.Ime = nt.Ime;
                n.Tip = nt.Tip;
                n.MinGodina = nt.MinGodina;
                n.OpasniEfekti = nt.OpasniEfekti;
                n.Predstava = predstava;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static NastupnaTackaBasic azurirajNastupnuTacku(NastupnaTackaBasic nt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n = s.Load<NastupnaTacka>(nt.IdTacke);

                n.Ime = nt.Ime;
                n.Tip = nt.Tip;
                n.MinGodina = nt.MinGodina;
                n.OpasniEfekti = nt.OpasniEfekti;

                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return nt;
        }
        public static NastupnaTackaBasic vratiNastupnuTacku(int id)
        {
            NastupnaTackaBasic nt = new NastupnaTackaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n = s.Load<NastupnaTacka>(id);
                nt = new NastupnaTackaBasic(n.IdTacke, n.Ime, n.Tip, n.MinGodina, n.OpasniEfekti);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return nt;
        }
        public static void obrisiNastupnuTacku(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n = s.Load<NastupnaTacka>(id);

                s.Delete(n);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static List<NastupnaTackaBasic> vratiNastupneTackePredstave(int predstavaID)
        {
            List<NastupnaTackaBasic> sveTacke = new List<NastupnaTackaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NastupnaTacka> tacke = from o in s.Query<NastupnaTacka>()
                                                   where o.Predstava.IdPredstave == predstavaID
                                                   select o;
                foreach (NastupnaTacka p in tacke)
                {
                    NastupnaTackaBasic preddd = new NastupnaTackaBasic(p);

                    preddd.Predstava = new CirkuskaPredstavaBasic(p.Predstava);

                    sveTacke.Add(preddd);

                }


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return sveTacke;
        }
        #endregion
        #region Artist
        public static List<ArtistBasic> vratiSveArtiste()
        {
            List<ArtistBasic> artisti = new List<ArtistBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Artist> sviArtisti = from o in s.Query<Artist>()
                                                 select o;

                foreach (Artist art in sviArtisti)
                {
                    var artist = new ArtistBasic(art);
                    artist.ImeArtista = art.JeZaposleni.Ime;
                    artist.PrezimeArtista = art.JeZaposleni.Prezime;
                    artisti.Add(new ArtistBasic(art.IdPerformera, art.UmetnickoIme, art.Pol, artist.ImeArtista, artist.PrezimeArtista));
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return artisti;
        }
        public static void dodajArtista(ArtistBasic artist)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Artist n = new Artist();

                Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                n.UmetnickoIme = artist.UmetnickoIme;
                n.Pol = artist.Pol;
                n.ClanOd = artist.ClanOd;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static ArtistBasic azurirajArtista(ArtistBasic art)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //NastupnaTacka n = s.Load<NastupnaTacka>(nt.IdTacke);
                Artist a = s.Load<Artist>(art.ArtistId);


                a.UmetnickoIme = art.UmetnickoIme;
                a.Pol = art.Pol;
                a.ClanOd = art.ClanOd;
                a.JeZaposleni.Ime = art.Zaposleni.Ime;
                a.JeZaposleni.Ime_Rod = art.Zaposleni.Ime_Rod;
                a.JeZaposleni.Prezime = art.Zaposleni.Prezime;
                a.JeZaposleni.Datum_Rodj = art.Zaposleni.Datum_Rodj;
                a.JeZaposleni.Mesto_Rodj = art.Zaposleni.Mesto_Rodj;
                a.JeZaposleni.Maticnibr = art.Zaposleni.Maticnibr;

                s.Update(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return art;
        }
        public static ArtistBasic vratiArtista(int id)
        {
            ArtistBasic art = new ArtistBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Artist a = s.Load<Artist>(id);
                art = new ArtistBasic(a.IdPerformera, a.JeZaposleni.Ime, a.JeZaposleni.Ime_Rod, a.JeZaposleni.Prezime, a.JeZaposleni.Maticnibr, a.UmetnickoIme, a.Pol, a.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return art;
        }
        public static void obrisiArtista(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Artist a = s.Load<Artist>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region Akrobata
        public static void dodajAkrobatuIzaposlenog(AkrobataBasic artist)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata n = new Akrobata();

                //n.IdPerformera = artist.ArtistId;
                //Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.IdZaposlenog);
                n.JeZaposleni = new Zaposleni();
                n.JeZaposleni.Ime = artist.ImeArtista;
                n.JeZaposleni.Prezime = artist.PrezimeArtista;
                n.JeZaposleni.Ime_Rod = artist.ImeRoditelja;
                n.JeZaposleni.Maticnibr = artist.MaticniBroj;
                n.JeZaposleni.Mesto_Rodj = artist.MestoRodj;
                n.JeZaposleni.Datum_Rodj = artist.DatumRodj;
                //n.JeZaposleni = a;
                n.UmetnickoIme = artist.UmetnickoIme;
                n.Pol = artist.Pol;
                n.ClanOd = artist.ClanOd;

                s.Save(n.JeZaposleni);
                n.JeZaposleni.JeArtist = n;
                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static List<AkrobataBasic> vratiAkrobate()
        {
            List<AkrobataBasic> artisti = new List<AkrobataBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Akrobata> sviArtisti = from o in s.Query<Akrobata>()
                                                   select o;

                foreach (Akrobata art in sviArtisti)
                {
                    var artist = new ArtistBasic(art);
                    artist.ImeArtista = art.JeZaposleni.Ime;
                    artist.PrezimeArtista = art.JeZaposleni.Prezime;
                    artisti.Add(new AkrobataBasic(art.IdPerformera, artist.ImeArtista, artist.ImeRoditelja, artist.PrezimeArtista, artist.MaticniBroj, art.UmetnickoIme, art.Pol, art.ClanOd));
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return artisti;
        }
        public static AkrobataBasic AzurirajAkrobatu(AkrobataBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata n = s.Load<Akrobata>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;

                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static void dodajAkrobatu(AkrobataBasic artist)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata n = new Akrobata();

                n.IdPerformera = artist.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                n.UmetnickoIme = artist.UmetnickoIme;
                n.Pol = artist.Pol;
                n.ClanOd = artist.ClanOd;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiAkrobatu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata akrobata = s.Load<Akrobata>(id);

                s.Delete(akrobata);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static AkrobataBasic vratiAkrobatu(int id)
        {
            AkrobataBasic mb = new AkrobataBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata akrobata = s.Load<Akrobata>(id);
                mb = new AkrobataBasic(akrobata.IdPerformera, akrobata.JeZaposleni.Ime, akrobata.JeZaposleni.Ime_Rod, akrobata.JeZaposleni.Prezime, akrobata.JeZaposleni.Maticnibr, akrobata.UmetnickoIme, akrobata.Pol, akrobata.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static void DodajAkrobatuIzaposlenog(AkrobataBasic artist)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata n = new Akrobata();

                n.IdPerformera = artist.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                n.UmetnickoIme = artist.UmetnickoIme;
                n.Pol = artist.Pol;
                n.ClanOd = artist.ClanOd;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion
        #region Zaposleni

        public static List<ZaposleniBasic> vratiSveZaposlene()
        {
            List<ZaposleniBasic> zaposleni = new List<ZaposleniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> svizaposleni = from o in s.Query<Zaposleni>()
                                                      select o;

                foreach (Zaposleni z in svizaposleni)
                {
                    zaposleni.Add(new ZaposleniBasic(z.IdZaposlenog, z.Ime, z.Ime_Rod, z.Prezime, z.Datum_Rodj, z.Mesto_Rodj, (long)z.Maticnibr));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return zaposleni;
        }

        public static ZaposleniBasic azurirajZaposlene(ZaposleniBasic zb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(zb.IdZaposlenog);

                if (zb.Ime != null)
                    z.Ime = zb.Ime;
                if (zb.Ime_Rod != null)
                    z.Ime_Rod = zb.Ime_Rod;
                if (zb.Prezime != null)
                    z.Prezime = zb.Prezime;
                if (zb.Datum_Rodj != null)
                    z.Datum_Rodj = zb.Datum_Rodj;
                if (zb.Mesto_Rodj != null)
                    z.Mesto_Rodj = zb.Mesto_Rodj;
                if (zb.Maticnibr != 0)
                    z.Maticnibr = zb.Maticnibr;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return zb;
        }

        public static ZaposleniBasic vratiZaposlenog(int id)
        {
            ZaposleniBasic zb = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(id);
                if (z != null)
                    zb = new ZaposleniBasic(z.IdZaposlenog, z.Ime, z.Ime_Rod, z.Prezime, z.Datum_Rodj, z.Mesto_Rodj, z.Maticnibr);

                s.Close();
                return zb;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }


        }

        public static void dodajZaposlenog(ZaposleniBasic zap)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = new Zaposleni();


                z.Ime = zap.Ime;
                z.Ime_Rod = zap.Ime_Rod;
                z.Prezime = zap.Prezime;
                z.Datum_Rodj = zap.Datum_Rodj;
                z.Mesto_Rodj = zap.Mesto_Rodj;
                z.Maticnibr = zap.Maticnibr;
                //Direktor d = s.Load<Direktor>(zap.PripadaDirektoru.IdDirektora);
                //z.PripadaDirektoru = d;

                s.SaveOrUpdate(z);

                s.Flush();
                //zap.IdZaposlenog = z.IdZaposlenog;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void obrisiZaposlenog(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(id);

                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion
        #region Direktor
        public static List<DirektorBasic> vratiSveDirektore()
        {
            List<DirektorBasic> direktori = new List<DirektorBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Direktor> svidirektori = from o in s.Query<Direktor>()
                                                     select o;

                foreach (Direktor d in svidirektori)
                {
                    var direktor = new DirektorBasic(d);
                    direktor.Zaposleni = d.Zaposleni.Select(d => new ZaposleniBasic(d)).ToList();
                    direktori.Add(direktor);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return direktori;
        }

        public static DirektorBasic azurirajDirektora(DirektorBasic db)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor d = s.Load<Direktor>(db.IdDirektora);

                d.IdDirektora = db.IdDirektora;
                d.Ime = db.Ime;
                d.Prezime = db.Prezime;
                d.Email = db.Email;
                d.Telefon = db.Telefon;

                s.Update(d);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return db;
        }

        public static DirektorBasic vratiDirektora(int id)
        {
            DirektorBasic db = new DirektorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor d = s.Load<Direktor>(id);
                db = new DirektorBasic(d.IdDirektora, d.Ime, d.Prezime, d.Email, d.Telefon);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return db;
        }

        public static void dodajDirektora(DirektorBasic dir)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor d = new Direktor();

                //d.IdDirektora = dir.IdDirektora;
                d.Ime = dir.Ime;
                d.Prezime = dir.Prezime;
                d.Email = dir.Email;
                d.Telefon = dir.Telefon;


                s.SaveOrUpdate(d);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void obrisiDirektora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor d = s.Load<Direktor>(id);

                s.Delete(d);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region PomocnoOsoblje
        public static List<PomocnoOsobljeBasic> vratiSvoPomocnoOsoblje()
        {
            List<PomocnoOsobljeBasic> osoblje = new List<PomocnoOsobljeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PomocnoOsoblje> svoOsoblje = from o in s.Query<PomocnoOsoblje>()
                                                         select o;

                foreach (PomocnoOsoblje po in svoOsoblje)
                {
                    osoblje.Add(new PomocnoOsobljeBasic(po.IdZaposlenog, po.Ime, po.Ime_Rod, po.Prezime, po.Datum_Rodj, po.Mesto_Rodj, po.Maticnibr, po.AsistentFleg));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return osoblje;
        }

        public static List<PomocnoOsobljeBasic> vratiSveAsistente()
        {
            List<PomocnoOsobljeBasic> osoblje = new List<PomocnoOsobljeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PomocnoOsoblje> svoOsoblje = from o in s.Query<PomocnoOsoblje>()
                                                         where o.AsistentFleg == true
                                                         select o;


                foreach (PomocnoOsoblje po in svoOsoblje)
                {
                    osoblje.Add(new PomocnoOsobljeBasic(po.IdZaposlenog, po.Ime, po.Ime_Rod, po.Prezime, po.Datum_Rodj, po.Mesto_Rodj, po.Maticnibr, po.AsistentFleg));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return osoblje;
        }

        public static void dodajPomocnoOsoblje(PomocnoOsobljeBasic pomocnoOsobljeBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var pomocnoOsoblje = new PomocnoOsoblje()
                {
                    Ime = pomocnoOsobljeBasic.Ime,
                    Ime_Rod = pomocnoOsobljeBasic.Ime_Rod,
                    Prezime = pomocnoOsobljeBasic.Prezime,
                    Datum_Rodj = pomocnoOsobljeBasic.Datum_Rodj,
                    Mesto_Rodj = pomocnoOsobljeBasic.Mesto_Rodj,
                    Maticnibr = pomocnoOsobljeBasic.Maticnibr
                };

                if (pomocnoOsobljeBasic.PripadaDirektoruID != 0)
                {
                    pomocnoOsoblje.PripadaDirektoru = s.Load<Direktor>(pomocnoOsobljeBasic.PripadaDirektoruID);//STO NE VADI INSTANCU??
                    pomocnoOsoblje.PripadaDirektoru.Zaposleni.Add(pomocnoOsoblje);
                }
                s.Save(pomocnoOsoblje);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static PomocnoOsobljeBasic vratiPomocnuOsobu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var osoba = s.Load<PomocnoOsoblje>(id);
                var osobaIzlaz = new PomocnoOsobljeBasic(osoba.IdZaposlenog, osoba.Ime, osoba.Ime_Rod, osoba.Prezime, osoba.Datum_Rodj, osoba.Mesto_Rodj, osoba.Maticnibr, osoba.AsistentFleg);
                s.Flush();
                s.Close();
                return osobaIzlaz;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }
        public static void obrisiPomocnuOsobu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var osoba = s.Load<PomocnoOsoblje>(id);

                s.Delete(osoba);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void azurirajPomocnuOsobu(PomocnoOsobljeBasic pomocnoOsobljeBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var osoba = s.Load<PomocnoOsoblje>(pomocnoOsobljeBasic.IdZaposlenog);

                if (pomocnoOsobljeBasic.Ime != null)
                    osoba.Ime = pomocnoOsobljeBasic.Ime;
                if (pomocnoOsobljeBasic.Ime_Rod != null)
                    osoba.Ime_Rod = pomocnoOsobljeBasic.Ime_Rod;
                if (pomocnoOsobljeBasic.Prezime != null)
                    osoba.Prezime = pomocnoOsobljeBasic.Prezime;
                if (pomocnoOsobljeBasic.Datum_Rodj != null)
                    osoba.Datum_Rodj = pomocnoOsobljeBasic.Datum_Rodj;
                if (pomocnoOsobljeBasic.Mesto_Rodj != null)
                    osoba.Mesto_Rodj = pomocnoOsobljeBasic.Mesto_Rodj;
                if (pomocnoOsobljeBasic.Maticnibr != 0)
                    osoba.Maticnibr = pomocnoOsobljeBasic.Maticnibr;

                s.Update(osoba);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion 
        #region Zivotinja
        public static List<ZivotinjaBasic> vratiSveZivotinja()
        {
            List<ZivotinjaBasic> zivotinje = new List<ZivotinjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zivotinja> sveZivotinja = from o in s.Query<Zivotinja>()
                                                      select o;

                foreach (Zivotinja z in sveZivotinja)
                {
                    var zivotinja = new ZivotinjaBasic(z);
                    zivotinja.ImeDresera = z.DresiraZivotinju.JeZaposleni.Ime;
                    zivotinje.Add(zivotinja);
                    //zivotinje.Add(new ZivotinjaBasic(z.IdPerformera, z.UmetnickoIme, z.Pol, z.ClanOd, z.Vrsta, z.Tezina, z.Starost));
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return zivotinje;
        }
        public static void dodajDreseraZivotinji(int drID, int zivID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Zivotinja z = new Zivotinja();
                Zivotinja z = s.Load<Zivotinja>(zivID);
                Dreser d = s.Load<Dreser>(drID);

                z.DresiraZivotinju = d;

                s.Update(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

        }

        public static void dodajZivotinju(ZivotinjaBasic zb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser dreser = s.Load<Dreser>(zb.DresiraZivotinju.ArtistId);
                Zivotinja z = new Zivotinja();

                z.IdPerformera = zb.IdPerformera;
                //Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.Id);
                //n.JeZaposleni=a
                z.UmetnickoIme = zb.UmetnickoIme;
                z.Pol = zb.Pol;
                z.ClanOd = zb.ClanOd;
                z.Vrsta = zb.Vrsta;
                z.Tezina = zb.Tezina;
                z.Starost = zb.Starost;
                z.DresiraZivotinju = dreser;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static ZivotinjaBasic azurirajZivotinju(ZivotinjaBasic zb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja z = s.Load<Zivotinja>(zb.IdPerformera);

                z.IdPerformera = zb.IdPerformera;
                z.UmetnickoIme = zb.UmetnickoIme;
                z.ClanOd = zb.ClanOd;
                z.Vrsta = zb.Vrsta;
                z.Tezina = zb.Tezina;
                z.Starost = zb.Starost;

                s.Update(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return zb;
        }
        public static ZivotinjaBasic vratiZivotinju(int id)
        {
            ZivotinjaBasic zb = new ZivotinjaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja z = s.Load<Zivotinja>(id);
                zb = new ZivotinjaBasic(z.IdPerformera, z.UmetnickoIme, z.Pol, z.ClanOd, z.Vrsta, z.Tezina, z.Starost);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return zb;
        }
        public static void obrisiZivotinju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja z = s.Load<Zivotinja>(id);

                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region CirkuskaPredstava

        public static List<CirkuskaPredstavaBasic> vratiSveCirkuskePredstave()
        {
            List<CirkuskaPredstavaBasic> predstaveIzlaz = new List<CirkuskaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<CirkuskaPredstava> predstave = from p in s.Query<CirkuskaPredstava>()
                                                           select p;

                foreach (CirkuskaPredstava pred in predstave)
                {
                    var predstava = new CirkuskaPredstavaBasic(pred);
                    predstava.Tacke = pred.Tacke.Select(pred => new NastupnaTackaBasic(pred)).ToList();
                    //mesta.Add(new MestoBoravkaBasic(mb.IdMesta, mb.Grad, mb.Drzava, mb.Opis, mb.VremeUGradu));
                    predstaveIzlaz.Add(predstava);
                    //predstaveIzlaz.Add(new CirkuskaPredstavaBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predstaveIzlaz;
        }

        public static void dodajCirkuskuPredstavu(CirkuskaPredstavaBasic cirkuskaPredstavaBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                MestoBoravka mesto = s.Load<MestoBoravka>(cirkuskaPredstavaBasic.Mesto.IdMesta);
                CirkuskaPredstava predstava = new CirkuskaPredstava();
                predstava.Vreme = cirkuskaPredstavaBasic.Vreme;
                predstava.BrojKarata = cirkuskaPredstavaBasic.BrojKarata;
                predstava.Mesto = mesto;

                s.Save(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void azurirajCirkuskuPredstavu(CirkuskaPredstavaBasic cirkuskaPredstavaBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaPredstava predstava = s.Load<CirkuskaPredstava>(cirkuskaPredstavaBasic.IdPredstave);
                predstava.Vreme = cirkuskaPredstavaBasic.Vreme;
                predstava.BrojKarata = cirkuskaPredstavaBasic.BrojKarata;

                s.Update(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static CirkuskaPredstavaBasic vratiCirkuskuPredstavu(int id)
        {
            CirkuskaPredstavaBasic cirkuskaPredstavaBasic = new CirkuskaPredstavaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaPredstava pred = s.Load<CirkuskaPredstava>(id);

                cirkuskaPredstavaBasic = new CirkuskaPredstavaBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata);

                s.Close();

                return cirkuskaPredstavaBasic;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }

        public static void obrisiCirkuskuPredstavu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaPredstava predstava = s.Load<CirkuskaPredstava>(id);

                s.Delete(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static List<CirkuskaPredstavaBasic> vratiPredstaveMesta(int mestoId)
        {
            List<CirkuskaPredstavaBasic> predstave = new List<CirkuskaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<CirkuskaPredstava> pred = from o in s.Query<CirkuskaPredstava>()
                                                      where o.Mesto.IdMesta == mestoId
                                                      select o;
                foreach (CirkuskaPredstava p in pred)
                {
                    CirkuskaPredstavaBasic preddd = new CirkuskaPredstavaBasic(p);

                    preddd.Mesto = new MestoBoravkaBasic(p.Mesto);

                    predstave.Add(preddd);

                }


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predstave;
        }
        #endregion
        #region Klovn
        public static void dodajKlovna(KlovnBasic klovn)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn n = new Klovn();

                n.IdPerformera = klovn.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(klovn.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                n.UmetnickoIme = klovn.UmetnickoIme;
                n.Pol = klovn.Pol;
                n.ClanOd = klovn.ClanOd;
                n.CimeZabavlja = klovn.CimeZabavlja;
                n.Tip = klovn.Tip;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiKlovna(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn klovn = s.Load<Klovn>(id);

                s.Delete(klovn);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static KlovnBasic azurirajKlovna(KlovnBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn n = s.Load<Klovn>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;
                n.Tip = mb.Tip;
                n.CimeZabavlja = n.CimeZabavlja;

                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static KlovnBasic vratiKlovna(int id)
        {
            KlovnBasic mb = new KlovnBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn klovn = s.Load<Klovn>(id);
                mb = new KlovnBasic(klovn.IdPerformera, klovn.JeZaposleni.Ime, klovn.JeZaposleni.Ime_Rod, klovn.JeZaposleni.Prezime, klovn.JeZaposleni.Maticnibr, klovn.UmetnickoIme, klovn.Pol, klovn.Tip, klovn.CimeZabavlja, klovn.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static List<KlovnBasic> vratiSveKlovnove()
        {
            List<KlovnBasic> artisti = new List<KlovnBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Klovn> sviArtisti = from o in s.Query<Klovn>()
                                                select o;

                foreach (Klovn klovn in sviArtisti)
                {
                    var artist = new KlovnBasic(klovn);
                    artist.ImeArtista = klovn.JeZaposleni.Ime;
                    artist.PrezimeArtista = klovn.JeZaposleni.Prezime;
                    artisti.Add(artist);
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return artisti;
        }

        #endregion
        #region Zongler
        public static void DodajZonglera(ZonglerBasic zongler)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler n = new Zongler();

                n.IdPerformera = zongler.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(zongler.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                n.UmetnickoIme = zongler.UmetnickoIme;
                n.Pol = zongler.Pol;
                n.ClanOd = zongler.ClanOd;
                n.NazivPredmeta = zongler.NazivPredmeta;
                n.MaxPredmeta = zongler.MaxPredmeta;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiZonglera(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler zongler = s.Load<Zongler>(id);

                s.Delete(zongler);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static ZonglerBasic azurirajZonglera(ZonglerBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler n = s.Load<Zongler>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;
                n.NazivPredmeta = mb.NazivPredmeta;
                n.MaxPredmeta = n.MaxPredmeta;

                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static ZonglerBasic vratiZonglera(int id)
        {
            ZonglerBasic mb = new ZonglerBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler zongler = s.Load<Zongler>(id);
                mb = new ZonglerBasic(zongler.IdPerformera, zongler.JeZaposleni.Ime, zongler.JeZaposleni.Ime_Rod, zongler.JeZaposleni.Prezime, zongler.JeZaposleni.Maticnibr, zongler.UmetnickoIme, zongler.Pol, zongler.NazivPredmeta, zongler.MaxPredmeta, zongler.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        #endregion
        #region  GutacPlamena
        public static void DodajGutacaPlamena(GutacPlamenaBasic gutac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutacPlamena n = new GutacPlamena();

                n.IdPerformera = gutac.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(gutac.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;

                n.UmetnickoIme = gutac.UmetnickoIme;
                n.Pol = gutac.Pol;
                n.ClanOd = gutac.ClanOd;



                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiGutacaPlamena(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutacPlamena gutac = s.Load<GutacPlamena>(id);

                s.Delete(gutac);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static GutacPlamenaBasic azurirajGutaca(GutacPlamenaBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutacPlamena n = s.Load<GutacPlamena>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;


                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static GutacPlamenaBasic vratiGutaca(int id)
        {
            GutacPlamenaBasic mb = new GutacPlamenaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                GutacPlamena gutac = s.Load<GutacPlamena>(id);
                mb = new GutacPlamenaBasic(gutac.IdPerformera, gutac.JeZaposleni.Ime, gutac.JeZaposleni.Ime_Rod, gutac.JeZaposleni.Prezime, gutac.JeZaposleni.Maticnibr, gutac.UmetnickoIme, gutac.Pol, gutac.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        #endregion
        #region Dreser
        public static List<DreserBasic> vratiDresere()
        {
            List<DreserBasic> artisti = new List<DreserBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Dreser> sviArtisti = from o in s.Query<Dreser>()
                                                 select o;
                IEnumerable<Zivotinja> sveZivotinje = from o in s.Query<Zivotinja>()
                                                      select o;
                IEnumerable<PomocnoOsoblje> sviasisteniti = from o in s.Query<PomocnoOsoblje>()
                                                            select o;



                foreach (Dreser art in sviArtisti)
                {
                    var artist = new DreserBasic(art);
                    foreach (Zivotinja ziv in sveZivotinje)
                    {
                        if (Equals(ziv.DresiraZivotinju, null))
                            continue;
                        if (art.IdPerformera == ziv.DresiraZivotinju.IdPerformera)
                        {
                            artist.Zivotinje.Add(new ZivotinjaBasic(ziv));
                        }
                    }
                    foreach (PomocnoOsoblje pom in sviasisteniti)
                    {
                        if (Equals(pom.PomazeArtistu, null))
                            continue;
                        if (art.IdPerformera == pom.PomazeArtistu.IdPerformera)
                        {
                            artist.Asistenti.Add(new PomocnoOsobljeBasic(pom));
                        }
                    }


                    //artist.Zivotinje = art.Zivotinje.Select(art => new ZivotinjaBasic(art)).ToList();
                    artist.ImeArtista = art.JeZaposleni.Ime;
                    artist.PrezimeArtista = art.JeZaposleni.Prezime;
                    // artisti.Add(new DreserBasic(art.IdPerformera,artist.ImeArtista,artist.PrezimeArtista, art.UmetnickoIme, art.Pol, art.ClanOd));
                    artisti.Add(artist);
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return artisti;
        }
        /*public static void DodajDreseraIZaposlenog(DreserBasic dreser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser n = new Dreser();

                n.IdPerformera = dreser.ArtistId;

                
                n.JeZaposleni = new Zaposleni();
                n.JeZaposleni.Ime = dreser.ImeArtista;
                
                n.JeZaposleni.Prezime = dreser.PrezimeArtista;
                n.UmetnickoIme = dreser.UmetnickoIme;
                n.Pol = dreser.Pol;
                n.ClanOd = dreser.ClanOd;


                s.Save(n.JeZaposleni);
                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }*/
        public static void dodajDresera(DreserBasic dreser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser n = new Dreser();

                n.IdPerformera = dreser.ArtistId;

                Zaposleni a = s.Load<Zaposleni>(dreser.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;
                //n.JeZaposleni = new Zaposleni();
                //n.JeZaposleni.Ime = dreser.ImeArtista;
                n.UmetnickoIme = dreser.UmetnickoIme;
                n.Pol = dreser.Pol;
                n.ClanOd = dreser.ClanOd;


                //s.Save(n.JeZaposleni);
                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiDresera(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser dreser = s.Load<Dreser>(id);

                s.Delete(dreser);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static DreserBasic azurirajDresera(DreserBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser n = s.Load<Dreser>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;


                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static DreserBasic vratiDresera(int id)
        {
            DreserBasic mb = new DreserBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser gutac = s.Load<Dreser>(id);
                mb = new DreserBasic(gutac.IdPerformera, gutac.JeZaposleni.Ime, gutac.JeZaposleni.Ime_Rod, gutac.JeZaposleni.Prezime, gutac.JeZaposleni.Maticnibr, gutac.UmetnickoIme, gutac.Pol, gutac.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        #endregion
        #region BacacNozeva
        public static void dodajBacacaNozeva(BacacNozevaBasic bacac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacacNozeva n = new BacacNozeva();

                n.IdPerformera = bacac.ArtistId;
                Zaposleni a = s.Load<Zaposleni>(bacac.Zaposleni.IdZaposlenog);

                n.JeZaposleni = a;

                n.UmetnickoIme = bacac.UmetnickoIme;
                n.Pol = bacac.Pol;
                n.ClanOd = bacac.ClanOd;



                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiBacacaNozeva(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacacNozeva bacac = s.Load<BacacNozeva>(id);

                s.Delete(bacac);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static BacacNozevaBasic azurirajBacacaNozeva(BacacNozevaBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacacNozeva n = s.Load<BacacNozeva>(mb.ArtistId);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.JeZaposleni.Ime = mb.ImeArtista;
                n.JeZaposleni.Prezime = mb.PrezimeArtista;

                n.UmetnickoIme = mb.UmetnickoIme;
                n.Pol = mb.Pol;
                n.ClanOd = mb.ClanOd;


                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static BacacNozevaBasic vratiBacaca(int id)
        {
            BacacNozevaBasic mb = new BacacNozevaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                BacacNozeva bacac = s.Load<BacacNozeva>(id);
                mb = new BacacNozevaBasic(bacac.IdPerformera, bacac.JeZaposleni.Ime, bacac.JeZaposleni.Ime_Rod, bacac.JeZaposleni.Prezime, bacac.JeZaposleni.Maticnibr, bacac.UmetnickoIme, bacac.Pol, bacac.ClanOd);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        #endregion
        #region HumanitarnaPredstava
        public static List<HumanitarnaPredstavaBasic> vratiSveHumanitarnePredstave()
        {
            List<HumanitarnaPredstavaBasic> predstaveIzlaz = new List<HumanitarnaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<HumanitarnaPredstava> predstave = from p in s.Query<HumanitarnaPredstava>()
                                                              select p;

                foreach (var pred in predstave)
                {
                    predstaveIzlaz.Add(new HumanitarnaPredstavaBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata, pred.Prihod, pred.ZaKoga));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predstaveIzlaz;
        }

        public static void dodajHumanitarnuPredstavu(HumanitarnaPredstavaBasic humanitarnaPredstavaBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                MestoBoravka mesto = s.Load<MestoBoravka>(humanitarnaPredstavaBasic.Mesto.IdMesta);
                HumanitarnaPredstava predstava = new HumanitarnaPredstava();
                predstava.Vreme = humanitarnaPredstavaBasic.Vreme;
                predstava.BrojKarata = humanitarnaPredstavaBasic.BrojKarata;
                predstava.Prihod = humanitarnaPredstavaBasic.Prihod;
                predstava.ZaKoga = humanitarnaPredstavaBasic.ZaKoga;
                predstava.Mesto = mesto;

                s.Save(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void azurirajHumanitarnuPredstavu(HumanitarnaPredstavaBasic cirkuskaPredstavaBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava predstava = s.Load<HumanitarnaPredstava>(cirkuskaPredstavaBasic.IdPredstave);
                predstava.Vreme = cirkuskaPredstavaBasic.Vreme;
                predstava.BrojKarata = cirkuskaPredstavaBasic.BrojKarata;
                predstava.Prihod = cirkuskaPredstavaBasic.Prihod;
                predstava.ZaKoga = cirkuskaPredstavaBasic.ZaKoga;


                s.Update(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static HumanitarnaPredstavaBasic vratiHumanitarnuPredstavu(int id)
        {
            HumanitarnaPredstavaBasic cirkuskaPredstavaBasic = new HumanitarnaPredstavaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava pred = s.Load<HumanitarnaPredstava>(id);

                cirkuskaPredstavaBasic = new HumanitarnaPredstavaBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata, pred.Prihod, pred.ZaKoga);

                s.Close();

                return cirkuskaPredstavaBasic;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }

        public static void obrisiHumanitarnuPredstavu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava predstava = s.Load<HumanitarnaPredstava>(id);

                s.Delete(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region PredstavaPoNarudzbini
        public static List<PredstavaPoNarudzbiniBasic> vratiSvePredstavePoNarudzbini()
        {
            List<PredstavaPoNarudzbiniBasic> predstaveIzlaz = new List<PredstavaPoNarudzbiniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PredstavaPoNarudzbini> predstave = from p in s.Query<PredstavaPoNarudzbini>()
                                                               select p;

                foreach (var pred in predstave)
                {
                    predstaveIzlaz.Add(new PredstavaPoNarudzbiniBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata, pred.BrTelNarucioca, pred.NazivNarucioca, pred.AdresaNarucioca));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predstaveIzlaz;
        }

        public static void dodajPredstavuPoNarudzbini(PredstavaPoNarudzbiniBasic predstavaPoNarudzbiniBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredstavaPoNarudzbini predstava = new PredstavaPoNarudzbini();
                predstava.Vreme = predstavaPoNarudzbiniBasic.Vreme;
                predstava.BrojKarata = predstavaPoNarudzbiniBasic.BrojKarata;
                predstava.BrTelNarucioca = predstavaPoNarudzbiniBasic.BrTelNarucioca;
                predstava.NazivNarucioca = predstavaPoNarudzbiniBasic.NazivNarucioca;
                predstava.AdresaNarucioca = predstavaPoNarudzbiniBasic.AdresaNarucioca;

                s.Save(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void azurirajPredstavuPoNarudzbini(PredstavaPoNarudzbiniBasic predstavaPoNarudzbiniBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredstavaPoNarudzbini predstava = s.Load<PredstavaPoNarudzbini>(predstavaPoNarudzbiniBasic.IdPredstave);
                predstava.Vreme = predstavaPoNarudzbiniBasic.Vreme;
                predstava.BrojKarata = predstavaPoNarudzbiniBasic.BrojKarata;
                predstava.BrTelNarucioca = predstavaPoNarudzbiniBasic.BrTelNarucioca;
                predstava.NazivNarucioca = predstavaPoNarudzbiniBasic.NazivNarucioca;
                predstava.AdresaNarucioca = predstavaPoNarudzbiniBasic.AdresaNarucioca;


                s.Update(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static PredstavaPoNarudzbiniBasic vratiPredstavuPoNarudzbini(int id)
        {
            PredstavaPoNarudzbiniBasic cirkuskaPredstavaBasic = new PredstavaPoNarudzbiniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                PredstavaPoNarudzbini pred = s.Load<PredstavaPoNarudzbini>(id);

                cirkuskaPredstavaBasic = new PredstavaPoNarudzbiniBasic(pred.IdPredstave, pred.Vreme, pred.BrojKarata, pred.BrTelNarucioca, pred.NazivNarucioca, pred.AdresaNarucioca);

                s.Close();

                return cirkuskaPredstavaBasic;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }

        public static void obrisiPredstavuPoNarudzbini(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredstavaPoNarudzbini predstava = s.Load<PredstavaPoNarudzbini>(id);

                s.Delete(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region Vestina
        public static void dodajVestinu(VestinaBasic vestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Vestina n = new Vestina();

                n.IdVestine = vestina.IdVestine;
                //Zaposleni a = s.Load<Zaposleni>(bacac.Zaposleni.IdZaposlenog);

                n.Naziv = vestina.Naziv;
                n.GodinaIskustva = vestina.GodinaIskustva;




                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void obrisiVestinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina vest = s.Load<Vestina>(id);

                s.Delete(vest);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static VestinaBasic azurirajvestinu(VestinaBasic mb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina n = s.Load<Vestina>(mb.IdVestine);

                //Zaposleni z = s.Load<Zaposleni>(mb.Zaposleni.IdZaposlenog);

                //n.JeZaposleni = z;
                n.Naziv = mb.Naziv;
                n.GodinaIskustva = mb.GodinaIskustva;


                //s.Update(z);
                s.Update(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static VestinaBasic vratiVestinu(int id)
        {
            VestinaBasic mb = new VestinaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina vest = s.Load<Vestina>(id);
                mb = new VestinaBasic(vest.IdVestine, vest.Naziv, vest.GodinaIskustva);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return mb;
        }
        public static List<VestinaBasic> VratiSveVestineAkrobate(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var vestine = (from a in s.Query<Akrobata>()
                               where a.IdPerformera == id
                               select a.Vestine).SingleOrDefault();

                var vestineIzlaz = new List<VestinaBasic>();

                foreach (var item in vestine)
                {
                    vestineIzlaz.Add(new VestinaBasic(item));
                }
                return vestineIzlaz;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }
        }
        public static List<AkrobataBasic> vratiSveAkrobateSaOdredjenomVestinom(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var akrobate = (from v in s.Query<Vestina>()
                                where v.IdVestine == id
                                select v.Akrobate).SingleOrDefault();

                var akrobateIzlaz = new List<AkrobataBasic>();
                foreach (var item in akrobate)
                {
                    akrobateIzlaz.Add(new AkrobataBasic(item));
                }
                return akrobateIzlaz;
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                return null;
            }

        }

        public static void DodajVestinu(VestinaBasic vestinaBasic, int akrobataID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var vestina = new Vestina()
                {
                    Naziv = vestinaBasic.Naziv,
                    GodinaIskustva = vestinaBasic.GodinaIskustva
                };
                var akrobata = s.Load<Akrobata>(akrobataID);
                if (akrobata != null)
                    vestina.Akrobate.Add(akrobata);

                s.Save(vestina);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void ObrisiVestinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var vestina = s.Load<Vestina>(id);
                s.Delete(vestina);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
    }
}

