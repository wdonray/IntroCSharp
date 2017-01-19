using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.FinalFantasy;
using System.Xml.Serialization;
using System.IO;


namespace CombatFSM.FinalFantasy
{
    public class Player
    {
        public Player() { }
        public Player(string n)
        {
            m_name = n;
        }
        private string m_name;
      
        public delegate void OnEndTurn();
        [XmlIgnore]
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

        public string Name { get { return m_name; }set { m_name = value; } }
    }
}
