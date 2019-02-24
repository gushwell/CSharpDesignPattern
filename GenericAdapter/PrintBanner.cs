using System;

namespace Gushwell.DesignPatterns {

    // 都合で、コンストラクタを削除、Textプロパティを追加
    public class PrintBanner<T> : IPrint where T : IBanner ,new() {    
        private T banner;

        public PrintBanner(string str) {
            banner = new T() {
                Text = str
            };
        }

        public void PrintWeak() {
            banner.ShowWithParen();
        }

        public void PrintStrong() {
            banner.ShowWithAster();
        }
    }
}

