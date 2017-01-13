using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.FinalFantasy;

namespace CombatFSM.FinalFantasy
{
    public class Player
    {
        public Player(string n)
        {
            m_name = n;
        }
        private string m_name;
        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;

        public void EndTurn()
        {
            if (onEndTurn != null)
                onEndTurn.Invoke();
        }
        public void Attack(Player p)
        {

        }
        public void Defend()
        {

        }
        public string Name { get { return m_name; } }
    }
}
