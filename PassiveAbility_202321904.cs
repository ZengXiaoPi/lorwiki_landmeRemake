using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class PassiveAbility_202321904 : PassiveAbilityBase
    {
        public override void OnRoundStart()
        {
            _num = 2;
            this.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, 2, null);
            List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList((this.owner.faction == Faction.Player) ? Faction.Enemy : Faction.Player);
            while (aliveList.Count > 0 && _num > 0)
            {
                BattleUnitModel battleUnitModel = RandomUtil.SelectOne<BattleUnitModel>(aliveList);
                aliveList.Remove(battleUnitModel);
                battleUnitModel.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, 2, this.owner);
                _num--;
            }
            }
        private string _note = "每幕开始时给予自己两层强壮，司书方随机两人两层强壮";
        private int _num;
    }
}
