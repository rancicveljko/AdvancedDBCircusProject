using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class GutacPlamenaPregled : ArtistPregled
    {
        public GutacPlamenaPregled()
        {

        }
        public GutacPlamenaPregled(int id, String UmIme, String pol) : base(id, UmIme, pol)
        {

        }
    }
}
