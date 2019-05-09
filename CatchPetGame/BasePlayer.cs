using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public abstract class BasePlayer
    {
        public virtual string playerName { get; }
        public virtual int defaultCatchPet { get; }
        public virtual int defaultMp { get; set; }
        
    }

   

    

}
