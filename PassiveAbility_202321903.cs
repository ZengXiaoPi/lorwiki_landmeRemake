using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class PassiveAbility_202321903 : PassiveAbilityBase
    {
        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            BattleCardTotalResult battleCardResultLog = this.owner.battleCardResultLog;
            if (battleCardResultLog != null)
            {
                battleCardResultLog.SetPassiveAbility(this);
            }
            if (this.owner.hp < this.owner.MaxHp * 0.5)
            {
                behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 4
                });
            }
            else
            {
                behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 2
                });
            }
        }
        public override void OnRoundStart()
        {
            this.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Vulnerable, 3, null);
        }
        private string _note = "HP高于50%时全骰子威力+2，低于50%时全骰子威力+4，同时每幕开始时获得三层易损";
    }
}
