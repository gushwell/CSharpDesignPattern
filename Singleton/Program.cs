using System;


namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Start.");
            var obj1 = Singleton.Instance;
            var obj2 = Singleton.Instance;
            if (obj1 == obj2) {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            } else {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }
            Console.WriteLine("End.");

            var t0 = Triple.GetInstance(0);
            var t1 = Triple.GetInstance(1);
            var t2 = Triple.GetInstance(2);
            var t3 = Triple.GetInstance(0);
            var t4 = Triple.GetInstance(1);
            var t5 = Triple.GetInstance(2);
            if( t0 == t1)
                Console.WriteLine("t0とt1は同じインスタンスです。");
            if (t0 == t2)
                Console.WriteLine("t0とt2は同じインスタンスです。");
            if (t0 == t3)
                Console.WriteLine("t0とt3は同じインスタンスです。");
            if (t0 == t4)
                Console.WriteLine("t0とt4は同じインスタンスです。");

            if (t1 == t2)
                Console.WriteLine("t1とt2は同じインスタンスです。");
            if (t1 == t3)
                Console.WriteLine("t1とt3は同じインスタンスです。");
            if (t1 == t4)
                Console.WriteLine("t1とt4は同じインスタンスです。");
            if (t1 == t5)
                Console.WriteLine("t1とt5は同じインスタンスです。");
        }
    }
}

