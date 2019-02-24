using System;

namespace Gushwell.DesignPatterns {

    // Borderには、Displayのインターフェースを受け継がせる
    public abstract class Border : Display {
        // この飾り枠がくるんでいる「中身」を指す。
        // ここが、Decoratorの肝の一つ。
        protected internal Display display; 
 
        // コンストラクタ：インスタンス生成時に「中身」を引数で指定
        protected internal Border(Display display) {
            this.display = display;
        }
    }
}

