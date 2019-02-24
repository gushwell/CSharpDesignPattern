using System;

namespace InterpreterSample {
    public interface INode {
        void Parse(Context context);
        void Print();
        void Run(Turtle turtle);
    }
}
