using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Initiative
{
    public class InitiativeTurn
    {
        public string Combatant;
        public string Initiative;

        public InitiativeTurn (string combatant, string initiative)
        {
            Combatant = combatant;
            Initiative = initiative;
        }
    }
}
