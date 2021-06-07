using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class BacaNozevaPregled : ArtistPregled
    {
        public BacaNozevaPregled()
        {

        }
        public BacaNozevaPregled(int id, String UmIme, String pol) : base(id, UmIme, pol)
        {

        }
    }
}
