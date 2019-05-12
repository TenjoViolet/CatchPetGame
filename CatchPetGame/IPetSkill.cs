using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    /// <summary>
    /// 寵物技能
    /// </summary>
    public interface IPetSkill
    {
        int petSkill { get; }

        void LearnSkill(BasePetSkill skill);
    }
}
