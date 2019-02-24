using System;

namespace Gushwell.DesignPatterns {

    // Displayの中身を実装するときに必要となるインターフェース
    // 機能とは独立して、実装を変更、拡張できる。
    public interface IDisplayImpl {
        void RawOpen();
        void RawPrint();
        void RawClose();
    }
}

