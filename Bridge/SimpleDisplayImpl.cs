using System;
using System.Collections.Generic;
using System.Text;

namespace Gushwell.DesignPatterns {
    class SimpleDisplayImpl : IDisplayImpl {

        private string str;         // 表示するべき文字列

        public SimpleDisplayImpl(string str) {
            this.str = str;
        }

        public void RawOpen() {

        }

        public void RawClose() {

        }
               
        public void RawPrint() {
            Console.WriteLine($"< {str} >"); // <> で括る
        }
    }
}
