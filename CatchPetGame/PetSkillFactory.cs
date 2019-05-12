using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPetGame
{
    public class PetSkillFactory
    {
        public  BasePetSkill GetRunAway()
        {
            return new RunAway();
        }
        public BasePetSkill GetSpuerRunAway()
        {
            return new SpuerRunAway();
        }
    }
}
