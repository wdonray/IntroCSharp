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
        public  string Name {get{ return m_name; }}
    }
}
