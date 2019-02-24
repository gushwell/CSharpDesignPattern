using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterSample {
    class StringTokenizer {
        private string[] strs;
        private int index = -1;
        
        public StringTokenizer(string text) {
            this.strs = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }
        public string NextToken() {
            return strs[++index];
        }

        public string CurrentToken() {
            return strs[index];
        }

        public bool HasMoreTokens() {
            return (index + 1) < strs.Length;
        }
    }
}
