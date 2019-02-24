using System;
using System.IO;
using System.Text;

namespace Gushwell.DesignPatterns {
    public class BigChar {
        private readonly string fontdata;    // 大きな文字を表現する文字列('#' '.' '\n'の列)

        // コンストラクタ
        public BigChar(char charname) {
            try {
                using (var reader = new StreamReader(@"data\big" + charname + ".txt")) {
                    var buf = new StringBuilder();
                    string line;
                    while ((line = reader.ReadLine()) != null) {
                        buf.AppendLine(line);
                    }
                    this.fontdata = buf.ToString();
                }
            } catch (System.IO.IOException) {
                this.fontdata = charname + "?";
            }
        }

        // 大きな文字を表示する
        public virtual void Print() {
            Console.Write(fontdata);
        }
    }
}

