using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.FinalFantasy;
namespace CombatFSM.FinalFantasy
{
    public class Combat
    {
        public Combat() { }
        public Party activeParty;
        /// <summary>
        /// Function to create a party
        /// </summary>
        /// <param name="p"></param>
        public void AddParty(Party p)
        {
            if (party.Count == 0)
            {
                party.Add(p);
                activeParty = party[0];
            }
            else
            {
                party.Add(p);
            }
            p.onPartyEnd += NextParty;
        }

        public void AddPlaya(Player a, int p)
        {
            party[p - 1].AddPlayer(a);
        }

        /// <summary>
        /// Function to go to the next Party
        /// </summary>
        public void NextParty()
        {
            int i = 0;
            foreach (Party p in party)
            {
                if (p == activeParty && i + 1 < party.Count)
                {
                    activeParty = party[i + 1];
                    break;
                }
                else if (activeParty == party[i] && i + 1 >= party.Count)
                {
                    activeParty = party[0];
                }
                i++;
            }
        }
        public void Load()
        {
            List<Party> temp = new List<Party>();
            for (int i = 0; i < party.Count; i++)
            {
                temp.Add(party[i]);
                temp[i].Load();
            }
            party = temp;
        }
        
        private List<Party> party = new List<Party>();
    }
}
