// About Namespace
/* In c# namespaces are used in two wayes
    1. .NET uses namespaces to organize its many classes 
        ex- System.Console.WriteLine("Hello World!"); //System is a namespace and Console is a class in that namespace

    2.  declaring your own namespaces can help you control the scope of class and method names
*/
using System;
namespace SampleNameSpace {
    class SampleNameSpaceTest {
        public void SampleMethod() {
            Console.WriteLine("Sample Method");
        }
    }

    /*
    //error- A namespace cannot directly contain members such as fields or methods
    public void testMethod() {
        Console.WriteLine("testMethod");
    }*/
}

namespace SampleNameSpaceTwo {
    class SampleNameSpaceTest {
        public void SampleMethod() {
            Console.WriteLine("Sample Method two");
        }
    }
}

class Program {
    static void Main() {
        SampleNameSpace.SampleNameSpaceTest a = new SampleNameSpace.SampleNameSpaceTest();
        a.SampleMethod();                       //op- Sample Method

        var b = new SampleNameSpaceTwo.SampleNameSpaceTest();
        b.SampleMethod();                       //op- Sample Method two
    }
}