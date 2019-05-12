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
        public Action<int, BaseCatchTool> everyCatchPet { get; set; }//委派

        public void EqipmentCatchTool(BaseCatchTool catchTool)
        {
            this.catchTool = catchTool;
        }

        /// <summary>
        /// 抓寵物
        /// </summary>
        /// <param name="targetPet"></param>
        public void Catch(BasePet targetPet)
        {
            int catchValue = GetRandomCatchValueWithCatchTool();
            targetPet.Caught(catchValue);

            if (everyCatchPet!=null)
            {
                everyCatchPet(catchValue, this.catchTool);
            }
            
        }

        private int GetRandomCatchValueWithCatchTool()
        {
            return this.catchTool == null ? playerCatchPet : playerCatchPet + this.catchTool.GetRandomCatchValue();
        }

    }


    public class 小智:BasePlayer
    {
        public override string playerName => "小智";
        public override int playerCatchPet => 10;

        
    }
   

    

}
