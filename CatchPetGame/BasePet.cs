using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public abstract class BasePet
    {
        public virtual string petName { get; }
        public virtual int defaultNotCatch { get; }
        public virtual int defaultRunAway { get; set; }

    }
}
