using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandMe_ReMake
{
    public class PassiveAbility_202321901 : PassiveAbilityBase
    {
        public override int GetSpeedDiceAdder(int speedDiceResult)
        {
            return 4;
        }
        public override int SpeedDiceBreakedAdder()
        {
            return 1;
        }
        public override void OnRoundStart()
        {
            this.owner.cardSlotDetail.RecoverPlayPoint(1);
        }
        private string _note = "开局获得速度骰子x4并碎裂一个骰子，每幕开始时额外恢复1点光芒";
    }
}
