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
        public virtual int petNotCatch { get; set; }
        
        public void Caught(int caughtValue)
        {
            this.petNotCatch -= caughtValue;
            
            if (this.petNotCatch <= 0)
            {
                //CatchSuccess();
            }
        }

    }
}
