using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public class PlayerEquipmentFactory
    {
        public BaseCatchTool GetBaseBall()
        {
            return new BaseBall();
        }

        public BaseCatchTool GetHigherBall()
        {
            return new HigherBall();
        }

        public BaseCatchTool GetBaseFood()
        {
            return new BaseFood();
        }

        public BaseCatchTool GetHigherFood()
        {
            return new HigherFood();
        }

    }
}
