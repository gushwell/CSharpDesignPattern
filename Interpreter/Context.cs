using System;
using InterpreterSample;

namespace InterpreterSample {
    public class Context {
        private StringTokenizer tokenizer;
        private string currentToken;

        public Context(string text) {
            tokenizer = new StringTokenizer(text);
            NextToken();
        }

        public virtual string NextToken() {
            if (tokenizer.HasMoreTokens()) {
                currentToken = tokenizer.NextToken();
            } else {
                currentToken = null;
            }
            return currentToken;
        }

        public virtual string CurrentToken() {
            return currentToken;
        }

        public virtual void SkipToken(string token) {
            if (!token.Equals(currentToken)) {
                throw new ParseException("Warning: " + token + " is expected, but " + currentToken + " is found.");
            }
            NextToken();
        }

        public virtual int CurrentNumber() {
            var number = 0;
            try {
                number = Int32.Parse(currentToken);
            } catch (System.FormatException e) {
                throw new ParseException("Warning: " + e);
            }
            return number;
        }
    }
}