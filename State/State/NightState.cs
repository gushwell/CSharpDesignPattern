using System;

namespace Gushwell.DesignPatterns {
    // 夜間の状態を表す
    public sealed class NightState : IState {
        // 唯一のインスタンスを得る
        public static IState Instance { get; } = new NightState();


        // コンストラクタはprivate
        private NightState() {
        }

        // 時刻設定
        public void DoClock(IContext context, int hour) {
            if (9 <= hour && hour < 17) {
                context.ChangeState(DayState.Instance);
            }
        }

        // 金庫使用
        public void DoUse(IContext context) {
            context.CallSecurityCenter("非常：夜間の金庫使用！");
        }

        // 非常ベル
        public void DoAlarm(IContext context) {
            context.CallSecurityCenter("非常ベル(夜間)");
        }

        // 通常通話
        public void DoPhone(IContext context) {
            context.RecordLog("夜間の通話録音");
        }
        
        // 文字列表現
        public override string ToString() {
            return "[夜間]";
        }
    }
}