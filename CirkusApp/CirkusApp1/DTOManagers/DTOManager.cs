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
        #endregion

    }
}
