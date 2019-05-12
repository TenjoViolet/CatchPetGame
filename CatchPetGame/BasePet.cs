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
        public virtual int petNotRunAway { get; set; }
        public Action WhenPetNotCatchIsZero { set; get; }//委派
        public Action WhenPetCanRunAway { set; get; }//委派

        /// <summary>
        /// 寵物被抓
        /// </summary>
        /// <param name="caughtValue"></param>
        public void Caught(int caughtValue)
        {
            if (this is IPetSkill)
            {
                this.petNotRunAway -= (this as IPetSkill).petCanRunAway;
            }

            if (this.petNotRunAway <= 0)
            {
                Catchfail();
            }

            this.petNotCatch -= caughtValue;

            if (this.petNotCatch <= 0)
            {
                CatchSuccess();
            }
        }

        /// <summary>
        /// 寵物抓取成功
        /// </summary>
        private void CatchSuccess()
        {
            WhenPetNotCatchIsZero.Invoke();
        } 

        private void Catchfail()
        {
            WhenPetCanRunAway.Invoke();
        }

    }

    public class 皮卡丘:BasePet
    {
        public override string petName => "皮卡丘";
        public override int petNotCatch { get; set; }
        public override int petNotRunAway { get; set; }


        public 皮卡丘()
        {
            this.petNotCatch = 30;
            this.petNotRunAway = 100;
        }

    }


    public class 超夢 : BasePet,IPetSkill
    {
        public override string petName => "超夢";
        public override int petNotCatch { get; set; }
        public override int petNotRunAway { get; set; }

        public int petSkill { get; set; }
        
        public 超夢()
        {
            this.petNotCatch = 9999999;
            this.petNotRunAway = 10;
        }
        public void LearnSkill(BasePetSkill skill)
        {
            petSkill = skill.petSkillValue;
        }

    }





}
