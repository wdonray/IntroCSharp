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
        public void addParty(Party a)
        {
            if (party.Count == 0)
            {
                party.Add(a);
                activeParty = party[0];
            }
            else
            {
                party.Add(a);
            }
        }
        private List<Party> party = new List<Party>();
    }
}
