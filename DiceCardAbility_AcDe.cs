using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class DiceCardAbility_AcDe : DiceCardAbilityBase
    {
        public override void OnSucceedAttack()
        {
            List<BattleDiceCardModel> list = this.owner.allyCardDetail.GetHand().FindAll((BattleDiceCardModel x) => x.CurCost > 0);
            if (list.Count > 0)
            {
                RandomUtil.SelectOne<BattleDiceCardModel>(list).AddBuf(new BattleDiceCardBuf_landcostdown0());
            }
        }
        public class BattleDiceCardBuf_landcostdown0 : BattleDiceCardBuf
        {
            public override int GetCost(int oldCost)
            {
                return 0;
            }
        }
        public static string Desc = "[命中时]使手中一张书页的费用归0";
    }
}
