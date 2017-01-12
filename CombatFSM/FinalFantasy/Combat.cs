using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.FinalFantasy;
namespace CombatFSM.FinalFantasy
{
    class Combat
    {
        public Combat() { }
        public Party activeParty;
        public void nextParty()
        {

        }
        public void nextPlaya()
        {

        }
        public void addParty(Player a)
        {
            if (party.Count == 0)
            {
                party.Add(a);
            }
            else
            {

            }
        }
        private List<Player> party = new List<Player>();
    }
}
