using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class State
    {
        public State(Enum e)
        {
            m_name = e.ToString();
        }
        private string m_name;
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;
    }

}
