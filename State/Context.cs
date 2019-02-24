using System;

namespace Gushwell.DesignPatterns {
    public interface IContext {
        void SetClock(int hour);  // 時刻の設定
        void ChangeState(IState state); // 状態変化
        void CallSecurityCenter(string msg); // 警備センター警備員呼び出し
        void RecordLog(string msg); // 警備センター記録
    }
}