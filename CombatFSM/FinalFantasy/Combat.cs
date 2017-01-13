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
        public void addPlaya(Player a, int p)
        {
            party[p - 1].addPlaya(a, 0);
        }
        public void nextParty()
        {
            int i = 0;
            foreach (Party a in party)
            {
                if (a == activeParty)
                {
                    activeParty = party[i + 1];
                    break;
                }
                i++;
            }
        }
        public void nextPlaya()
        {
            if (activeParty.cannextActivePlaya() == false)
            {
                nextParty();
            }
            else
                activeParty.nextActivePlaya();
        }
        private List<Party> party = new List<Party>();
    }
}
