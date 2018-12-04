using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway // interface is always public so no need to add 'public'
    {
        void WalkAway(Player player); // return of void (no return value is needed)
    }
}
