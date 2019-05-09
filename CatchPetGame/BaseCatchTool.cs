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
    }
}
