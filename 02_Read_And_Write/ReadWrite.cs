using System;
class Program {
    static void Main() {
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Hello "+ name);

        //Place holder Syntax
        Console.WriteLine("Hello {0}", name);

    }
}