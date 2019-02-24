using System;

namespace Gushwell.DesignPatterns {
    // 昼間の状態を表す
    public sealed class DayState : IState {
        // 唯一のインスタンスを得る
        public static IState Instance { get; } = new DayState();

        
        // コンストラクタはprivate
        private DayState() {
        }
        
        // 時刻設定
        public void DoClock(IContext context, int hour) {
            if (hour < 9 || 17 <= hour) {
                context.ChangeState(NightState.Instance);
            }
        }
        
        // 金庫使用
        public void DoUse(IContext context) {
            context.RecordLog("金庫使用(昼間)");
        }
        
        // 非常ベル
        public void DoAlarm(IContext context) {
            context.CallSecurityCenter("非常ベル(昼間)");
        }
        
        // 通常通話
        public void DoPhone(IContext context) {
            context.CallSecurityCenter("通常の通話(昼間)");
        }

        // 文字列表現
        public override string ToString() {
            return "[昼間]";
        }
    }
}