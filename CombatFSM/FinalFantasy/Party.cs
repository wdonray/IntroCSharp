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
        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;
        /// <summary>
        /// Function to set the next player in the list to be the active player
        /// </summary>
        int currentID = 0;
        public void GetNext()
        {
            if (currentID >= players.Count - 1)
            {
                currentID = 0;
                activePlaya = players[currentID];
                if (onPartyEnd != null)
                    onPartyEnd.Invoke();
                return;
            }
            currentID++;
            activePlaya = players[currentID];
        }
        /// <summary>
        /// Bool to check if you can go to the next player
        /// </summary>
        /// <returns></returns>
        public bool CanNextActivePlaya()
        {
            int i = 0;
            foreach (Player p in players)
            {
                if (i == players.Count - 1)
                {
                    activePlaya = players[0];
                    return false;
                }
                else if (p == activePlaya)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
        /// <summary>
        /// Function to be able to create a player and add it to a party
        /// </summary>
        /// <param name="p"></param>
        /// <param name="party"></param>
        public void AddPlayer(Player p, int party)
        {
            if (players.Count <= currentID)
            {
                players.Add(p);
                activePlaya = players[currentID];
            }
            players.Add(p);
            p.onEndTurn += GetNext;
        }
        private List<Player> players = new List<Player>();
    }
}
