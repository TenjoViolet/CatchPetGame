using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public abstract class BasePetSkill
    {
        public abstract int petSkillValue { get; }
    }

    public class RunAway:BasePetSkill
    {
        public override int petSkillValue => 1;
    }

    public class SpuerRunAway : BasePetSkill
    {
        public override int petSkillValue =>9999999;
    }
}
