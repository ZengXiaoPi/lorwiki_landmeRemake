using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class PassiveAbility_202321902 : PassiveAbilityBase
    {
        public override int GetEmotionCoinAdder(int defaultCount)
        {
            return defaultCount;
        }
        private string _note = "获得双倍情感硬币";
    }
}
