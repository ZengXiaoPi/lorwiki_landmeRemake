using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class DiceCardSelfAbility_landrecover2point : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            this.owner.cardSlotDetail.RecoverPlayPoint(2);
        }
        public static string Desc = "[使用时]恢复2点光芒";
    }
}
