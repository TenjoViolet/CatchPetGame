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
        public virtual int playerCatchPet { get; }
        public virtual int playerMp { get; set; }
        public BaseCatchTool catchTool { private set; get; }
        public Action<int, BaseCatchTool> everyCatchPet { get; set; }

        public void EqipmentCatchTool(BaseCatchTool catchTool)
        {
            this.catchTool = catchTool;
        }

        public void Catch(BasePet targetPet)
        {
            int catchValue = GetRandomCatchValueWithCatchTool();


            if (everyCatchPet!=null)
            {
                everyCatchPet(catchValue, this.catchTool);
            }
            
        }

        private int GetRandomCatchValueWithCatchTool()
        {
            return this.catchTool = null ? playerCatchPet : playerCatchPet + this.catchTool.GetRandomCatchValue();
        }

    }

   

    

}
