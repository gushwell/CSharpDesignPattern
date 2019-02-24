using System;
using System.Drawing;

namespace InterpreterSample {
    // <program> ::= program <command list>
    public class ProgramNode : INode {
        private INode commandListNode;

        public void Parse(Context context) {
            context.SkipToken("program");
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }

        public override string ToString() {
            return "[program " + commandListNode + "]";
        }
        
        public void Print() {
            commandListNode.Print();
        }
        
        public void Run(Turtle turtle) {
            commandListNode.Run(turtle);
        }
    }
}