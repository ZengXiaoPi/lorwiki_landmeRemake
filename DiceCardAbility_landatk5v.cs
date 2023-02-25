using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class DiceCardAbility_landatk5v : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if (target != null)
            {
                target.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Vulnerable, 5, base.owner);
            }
        }
        public static string Desc = "[命中时]施加5层[易损]";
    }
}
