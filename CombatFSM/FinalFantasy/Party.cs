using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.FinalFantasy;

namespace CombatFSM.FinalFantasy
{
    class Party
    {
        public Party() { }
        public Player activePlaya;
        public void addPlaya(Player a, int party)
        {
            players.Add(a);
        }
        private List<Player> players = new List<Player>();
    }
}
