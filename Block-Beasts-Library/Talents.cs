using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Beasts_Library
{
    public enum Talents //TODO make a random system to assign new talents to block-mon when hatched
    { // Numbered to make things easier when randomzing the selection for rolling 
        Timid = 0, // dodge ability increased (12.5%)
        strong = 1, // extra attack power (12.5%)
        boring = 2, // No buff/Nerf applied to mon (50%) 
        Clumsy = 3, // A more likely chance to miss your attacks (12.5%)
        Weak = 4, // less attack power (12.5%

    }
}
