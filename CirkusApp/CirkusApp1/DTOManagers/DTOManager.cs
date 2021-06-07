using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CirkusApp1.DTOs.Basics;
using CirkusApp1.DTOs.Pregledi;
using CirkusApp1.Entiteti;
using NHibernate;

namespace CirkusApp1.DTOManagers
{
    public class DTOManager
    {
        #region NastupnaTacka
        public static List<NastupnaTackaPregled> vratiSveNastupneTacke()
        {
            List<NastupnaTackaPregled> tacke = new List<NastupnaTackaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NastupnaTacka> sveTacke = from o in s.Query<NastupnaTacka>()
                                                                            select o;

                foreach (NastupnaTacka nt in sveTacke)
                {
                    tacke.Add(new NastupnaTackaPregled(nt.IdTacke, nt.Ime, nt.Tip, nt.MinGodina, nt.OpasniEfekti));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return tacke;
        }
        public static void dodajNastupnuTacku(NastupnaTackaBasic nt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n = new NastupnaTacka();

                n.IdTacke = nt.IdTacke;
                n.Ime = nt.Ime;
                n.Tip = nt.Tip;
                n.MinGodina = nt.MinGodina;
                n.OpasniEfekti = nt.OpasniEfekti;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static NastupnaTackaBasic azurirajProdavnicu(NastupnaTackaBasic nt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastupnaTacka n= s.Load<NastupnaTacka>(nt.IdTacke);

                n.IdTacke = nt.IdTacke;
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
                //handle exceptions
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
                //handle exceptions
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
                //handle exceptions
            }
        }
        #endregion
        #region Artist
        public static List<ArtistPregled> vratiSveArtiste()
        {
            List<ArtistPregled> artisti = new List<ArtistPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Artist> sviArtisti = from o in s.Query<Artist>()
                                                 select o;

                foreach (Artist art in sviArtisti)
                {
                    artisti.Add(new ArtistPregled(art.IdPerformera, art.UmetnickoIme, art.Pol));
                }

            }
            catch (Exception ec)
            {

            }
            return artisti;
        }
        public static void dodajArtista(ArtistBasic artist)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Artist n = new Artist();

                n.IdPerformera = artist.ArtistId;
                //Zaposleni a = s.Load<Zaposleni>(artist.Zaposleni.Id);
                //n.JeZaposleni=a
                n.UmetnickoIme = artist.UmetnickoIme;
                n.Pol = artist.Pol;
                n.ClanOd = artist.ClanOd;

                s.SaveOrUpdate(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        #endregion
        #region Zaposleni

        public static List<ZaposleniPregled> vratiSveZaposlene()
        {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> svizaposleni = from o in s.Query<Zaposleni>()
                                                      select o;

                foreach (Zaposleni z in svizaposleni)
                {
                    zaposleni.Add(new ZaposleniPregled(z.IdZaposlenog, z.Ime, z.Ime_Rod, z.Prezime, z.Datum_Rodj, z.Mesto_Rodj, (int)z.Maticnibr));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zaposleni;
        }

        public static ZaposleniBasic azurirajZaposlene(ZaposleniBasic zb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(zb.IdZaposlenog);

                z.IdZaposlenog = zb.IdZaposlenog;
                z.Ime = zb.Ime;
                z.Ime_Rod = zb.Ime_Rod;
                z.Prezime = zb.Prezime;
                z.Datum_Rodj = zb.Datum_Rodj;
                z.Mesto_Rodj = zb.Mesto_Rodj;
                z.Maticnibr = zb.Maticnibr;

                s.Update(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zb;
        }

        public static ZaposleniBasic vratiZaposlenog(int id)
        {
            ZaposleniBasic zb = new ZaposleniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(id);
                zb = new ZaposleniBasic(z.IdZaposlenog, z.Ime, z.Ime_Rod, z.Prezime, z.Datum_Rodj, z.Mesto_Rodj, (int)z.Maticnibr);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zb;
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
                Direktor d = s.Load<Direktor>(zap.PripadaDirektoru.IdDirektora);
                z.PripadaDirektoru = d;

                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
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
                //handle exceptions
            }
        }

        #endregion

        #region Direktor
        public static List<DirektorPregled> vratiSveDirektore()
        {
            List<DirektorPregled> direktori = new List<DirektorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Direktor> svidirektori = from o in s.Query<Direktor>()
                                                     select o;

                foreach (Direktor d in svidirektori)
                {
                    direktori.Add(new DirektorPregled(d.IdDirektora, d.Ime, d.Prezime, d.Email, d.Telefon));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
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
                //handle exceptions
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
                //handle exceptions
            }

            return db;
        }

        public static void dodajDirektora(Direktor dir)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor d = new Direktor();

                d.IdDirektora = dir.IdDirektora;
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
                //handle exceptions
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
                //handle exceptions
            }
        }
        #endregion
    }
}
   
