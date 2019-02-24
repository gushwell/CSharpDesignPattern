using System;

namespace InterpreterSample {
    // <repeat command> ::= repeat <number> <command list>
    public class RepeatCommandNode : INode {
        private int number;
        private INode commandListNode;

        public void Parse(Context context) {
            context.SkipToken("repeat");
            number = context.CurrentNumber();
            context.NextToken();
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }

        public override string ToString() {
            return "[repeat " + number + " " + commandListNode.ToString() + "]";
        }
        
        public void Print() {
            for (var i = 0; i < number; i++) {
                commandListNode.Print();
            }
        }

        public void Run(Turtle turtle) {
            for (var i = 0; i < number; i++) {
                commandListNode.Run(turtle);
            }
        }
    }
}