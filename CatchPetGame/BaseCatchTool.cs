using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public enum CatchToolType
    {
        Food,
        Ball,
    }
    public abstract class BaseCatchTool
    {
        public abstract string catchToolName { get; }
        public abstract CatchToolType catchToolType { get; }
        public abstract int maxCatch { get; }
        public abstract int minCatch { get; }

        public int GetRandomCatchValue()
        {
            return new Random().Next(minCatch, maxCatch);
        }
    }


    public class  BaseBall:BaseCatchTool
    {
        public override string catchToolName => "BaseBall";
        public override CatchToolType catchToolType => CatchToolType.Ball;
        public override int maxCatch => 5;
        public override int minCatch => 1;

    }

    public class HigherBall : BaseCatchTool
    {
        public override string catchToolName => "HigherBall";
        public override CatchToolType catchToolType => CatchToolType.Ball;
        public override int maxCatch => 10;
        public override int minCatch => 2;

    }

    public class BaseFood : BaseCatchTool
    {
        public override string catchToolName => "BaseFood";
        public override CatchToolType catchToolType => CatchToolType.Food;
        public override int maxCatch => 3;
        public override int minCatch => 1;

    }

    public class HigherFood : BaseCatchTool
    {
        public override string catchToolName => "BaseFood";
        public override CatchToolType catchToolType => CatchToolType.Food;
        public override int maxCatch => 6;
        public override int minCatch => 1;

    }

}
