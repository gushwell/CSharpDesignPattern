using System;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    // 抽象クラスAbstractDisplay 
    // これがテンプレートとなるクラス。ここから具象クラスを派生させる
    public abstract class AbstractDisplay {
        // サブクラスに実装をまかせる抽象メソッド(1) Open
        public abstract void Open();
        
        // サブクラスに実装をまかせる抽象メソッド(2) Print
        public abstract void Print();

        // サブクラスに実装をまかせる抽象メソッド(3) Close
        public abstract void Close(); 

        // この抽象クラスで実装しているメソッドDisplay
        public void Display() {
            Open();                   // まずopenして…
            5.Times(() => Print());   // 5回printを繰り返して…
            Close();                  // …最後にCloseする。
                                      // これがDisplayメソッドで実装されている内容。
        }
    }
}

