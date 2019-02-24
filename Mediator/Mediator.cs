using System;

namespace Gushwell.DesignPatterns {
    // 調停者、仲裁者
    // 多数のオブジェクトの調停役
    public interface IMediator {
        void CreateColleagues();
        void ColleagueChanged();
    }
}