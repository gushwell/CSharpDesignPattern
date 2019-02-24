using System;

namespace Gushwell.DesignPatterns {
    // このアプリで状態を持つオブジェクトが持つべきインターフェース
    public interface IState {
        void DoClock(IContext context, int hour); // 時刻設定
        void DoUse(IContext context); // 金庫使用
        void DoAlarm(IContext context); // 非常ベル
        void DoPhone(IContext context); // 通常通話
    }
}