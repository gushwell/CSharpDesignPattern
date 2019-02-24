using System;

namespace Gushwell.DesignPatterns {

    public class File : Entry {
        public override string Name { get; protected set; }
        public override int Size { get; protected set; }

        public File(string name, int size) {
            Name = name;
            Size = size;
        }

        protected internal override void PrintList(string prefix) {
            Console.WriteLine(prefix + "/" + this.ToString());
        }
    }
}

