using System;

namespace Gushwell.DesignPatterns {
    // 同僚、仲間
    public interface IColleague {
        // 調停者を設定する
        void SetMediator(IMediator mediator);

        // Colleagueが本来持つ振る舞い
        void SetColleagueEnabled(bool enabled);
    }
}