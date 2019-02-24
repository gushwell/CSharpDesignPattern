using System;

namespace InterpreterSample {
    [Serializable]
    public class ParseException : System.Exception {
        public ParseException(string msg)
            : base(msg) {
        }
    }
}