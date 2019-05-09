using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public enum CatchToolType
    {
        baseFood,
        highFood,
        superFood,
        baseBall,
        highBall,
        spuerBall
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






}
