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
        public Party partyOne = new Party();
        public Party partyTwo = new Party();
    }
}
