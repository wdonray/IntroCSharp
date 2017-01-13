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
        public void nextActivePlaya()
        {
            int i = 0;
            foreach (Player a in players)
            {
                if (a == activePlaya)
                {
                    activePlaya = players[i + 1];
                    break;
                }
                i++;
            }
        }
        public bool cannextActivePlaya()
        {
            int i = 0;
            foreach (Player a in players)
            {
                if (i == players.Count - 1)
                {
                    return false;
                }
                else if (a == activePlaya)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public void addPlaya(Player a, int party)
        {
            if (players.Count == 0)
            {
                players.Add(a);
                activePlaya = players[0];
            }
            else
                players.Add(a);
        }
        private List<Player> players = new List<Player>();
    }
}
