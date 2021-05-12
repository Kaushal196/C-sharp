/*
1. To allow the use of types in a namespace
   ex using System.Text
2. To allow you to access static members and nested types
    ex. using static System.Math
3. To create an alias for a namespace or a type
    ex. using Project = PC.MyCompany.Project
*/


using System;
using NameSpaceTest1;
using NameSpaceTest2;
using NameSpaceTest3.NamSpaceTest4;

namespace NameSpaceTest1 {
    class Test1 {
        public void Testfunc() {
            Console.WriteLine("Test func");
        }
    }

    class Test12 {
        public void Testfunc() {
            Console.WriteLine("Test fun 12");
        }
    }
}

namespace NameSpaceTest2 {
    class Test1 {
        public void Testfunc() {
            Console.WriteLine("Test fun 2");
        }
    }
    class Test21 {
        public void Testfunc() {
            Console.WriteLine("Test fun 21");
        }
    }
}

//we can also use nested namespace
namespace NameSpaceTest3 {
    namespace  NamSpaceTest4 {
        class Test4 {
            
            /*
            Method names which are same as the class name are called constructors. 
            Constructors do not have a return type
            error at line 31- 'Test4': member names cannot be the same as their enclosing type
            public void Test4() {
                Console.WriteLine("Test 4");
            }
            */

            public void TestFun4() {
                Console.WriteLine("Test Fun 4");
            }
        }
    }
}

class Program {
    static void Main() {
        /*
        Test1 a = new Test1();
        //line 23 error - 'Test1' is an ambiguous reference between 'NameSpaceTest1.Test1' and 'NameSpaceTest2.Test1'
        a.Testfunc();
        */

        Test4 b = new Test4();
        b.TestFun4();        // op- Test Fun 4

        Test12 a = new Test12();
        a.Testfunc();       // op- Test Fun 12

        Test21 c = new Test21();
        c.Testfunc();       // op- Test Fun 21
    }
}