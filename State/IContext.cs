using System;

namespace Gushwell.DesignPatterns {
    // 各StateオブジェクトがFormという具象クラスに依存しないようにインターフェースを定義する。
    // 各Stateオブジェクトは、このメソッドを利用して状態毎の動作をする
    public interface IContext {
        void SetClock(int hour);  // 時刻の設定
        void ChangeState(IState state); // 状態変化
        void CallSecurityCenter(string msg); // 警備センター警備員呼び出し
        void RecordLog(string msg); // 警備センター記録
    }
}