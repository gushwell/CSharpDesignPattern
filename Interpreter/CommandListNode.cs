using System;
using System.Linq;
using System.Collections.Generic;

namespace InterpreterSample {
    // <command list> ::= <command>* end
    public class CommandListNode : INode {
        private List<INode> list = new List<INode>();
        public void Parse(Context context) {
            while (true) {
                if (context.CurrentToken() == null) {
                    throw new ParseException("Missing 'end'");
                } else if (context.CurrentToken().Equals("end")) {
                    context.SkipToken("end");
                    break;
                } else {
                    INode commandNode = new CommandNode();
                    commandNode.Parse(context);
                    list.Add(commandNode);
                }
            }
        }

        public override string ToString() {
            return list.Aggregate("", (s, node) => s + (node.ToString() + ' '));
        }
        
        public void Print() {
            list.ForEach(node => node.Print());
        }
        
        public void Run(Turtle turtle) {
            list.ForEach(node => node.Run(turtle));
        }
    }
}