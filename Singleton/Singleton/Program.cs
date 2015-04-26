using System;

namespace Singleton
{
    class Program
    {
        //Test classes
        class Test1 { }
        class Test2 { }

        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Eager EagerSingleton Test");
            Console.WriteLine("************************************");

            //These Should Pass
            EagerSingleton eagerSingleton1 = EagerSingleton.Instance;
            EagerSingleton eagerSingleton2 = EagerSingleton.Instance;
            Console.WriteLine("Is eager1==eager2: " + (eagerSingleton1 == eagerSingleton2));
            Console.WriteLine("Extra test for fun: " + Object.ReferenceEquals(eagerSingleton1, eagerSingleton2));
            Console.WriteLine();

            Console.WriteLine("************************************");
            Console.WriteLine("Lazy EagerSingleton Test");
            Console.WriteLine("************************************");

            //These Should Pass
            LazySingleton lazySingleton1 = LazySingleton.Instance;
            LazySingleton lazySingleton2 = LazySingleton.Instance;
            Console.WriteLine("Is lazy1==lazy2: " + (lazySingleton1 == lazySingleton2));
            Console.WriteLine("Extra test for fun: " + Object.ReferenceEquals(lazySingleton1, lazySingleton2));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine("Generic Lazy Loading EagerSingleton Test");
            Console.WriteLine("************************************");

            //These Should Pass
            Test1 test1A = Singleton<Test1>.Instance;
            Test1 test1B = Singleton<Test1>.Instance;
            Console.WriteLine("Is t1A==t1B: " + (test1A==test1B));
            Console.WriteLine("Extra test for fun: " + Object.ReferenceEquals(test1A, test1B));
            Console.WriteLine();

            //These should Fail
            Test2 test2A = Singleton<Test2>.Instance;
            Test2 test2B = new Test2();
            Console.WriteLine("Is t2A==t2B: " + (test2A == test2B));
            Console.WriteLine("Extra test for fun: " + Object.ReferenceEquals(test2A, test2B));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
