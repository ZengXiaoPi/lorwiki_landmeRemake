using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class DiceCardAbility_land5bleeding : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Bleeding,5,null);
        }
        public static string Desc = "[命中时]下一幕开始时施加5层[流血]";
    }
}
