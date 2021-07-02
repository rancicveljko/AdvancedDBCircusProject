using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class VestinaBasic
    {
        public  int IdVestine { get; set; }
        public  String Naziv { get; set; }
        public  int GodinaIskustva { get; set; }
        public  IList<AkrobataBasic> Akrobate { get; set; }

        public VestinaBasic()
        {
            Akrobate = new List<AkrobataBasic>();
        }
        public VestinaBasic(int idvest,String naziv,int god)
        {
            this.IdVestine = idvest;
            this.Naziv = naziv;
            this.GodinaIskustva = god;
            Akrobate = new List<AkrobataBasic>();
        }
        public VestinaBasic(Vestina v)
        {
            this.IdVestine = v.IdVestine;
            this.GodinaIskustva = v.GodinaIskustva;
            this.Naziv = v.Naziv;
        }
    }
}
