using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class DiceCardAbility_landatk3protect : DiceCardAbilityBase
    {
        public override void OnSucceedAttack()
        {
            this.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Protection, 3, null);
        }
        public static string Desc = "[命中时]下一幕开始时获得3层[守护]";
    }
}
