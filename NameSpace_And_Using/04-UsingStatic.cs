// Syntax- using static <fully-qualified-type-name>;


using System;
/*using System.Math; 
error -  A 'using namespace' directive can only be applied to namespaces; 
'Math' is a type not a namespace. Consider a 'using static' directive instead
*/
using static System.Math;
using static System.Console;

class Circle {
    public Circle(double radius) {
        Radius = radius;
    }
    public double Radius { get; set; }

    public double DiaMeter {
        get { return 2 * Radius; }
    }

    public double Circumference {
      //get { return 2 * Radius * Math.PI; }
      get { return 2 * Radius * PI; }
   }

   public double Area {
      //get { return Math.PI * Math.Pow(Radius, 2); }
      get { return PI * Pow(Radius, 2); }
   }
}

class Program {
    static void Main() {
        Circle c = new Circle(5);
        /*
        Console.WriteLine("Radius: {0}", c.Radius);
        Console.WriteLine("DiaMeter: {0}", c.DiaMeter);
        Console.WriteLine("Circumference: {0}", c.Circumference);
        Console.WriteLine("Area: {0}", c.Area);
        */

        WriteLine("Radius: {0}", c.Radius);
        WriteLine("DiaMeter: {0}", c.DiaMeter);
        WriteLine("Circumference: {0}", c.Circumference);
        WriteLine("Area: {0}", c.Area);

        /*
            Radius: 5
            DiaMeter: 10
            Circumference: 31.4159265358979
            Area: 78.5398163397448
        */
    }
}