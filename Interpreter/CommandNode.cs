using System;

namespace InterpreterSample {
    // <command> ::= <repeat command> | <primitive command>
    public class CommandNode : INode {
        private INode node;

        public void Parse(Context context) {
            if (context.CurrentToken().Equals("repeat")) {
                node = new RepeatCommandNode();
                node.Parse(context);
            } else {
                node = new PrimitiveCommandNode();
                node.Parse(context);
            }
        }

        public override string ToString() {
            return node.ToString();
        }
        
        public void Print() {
            node.Print();
        }
        
        public void Run(Turtle turtle) {
            node.Run(turtle);
        }
    }
}