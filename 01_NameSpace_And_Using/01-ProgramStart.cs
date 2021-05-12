using System;   //NameSpace declaration
/*It indicates that we are using System namespace
A namespace is used to organize our code and is collection 
of classes, interfaces, structs, enums and delegates
*/

class Program {

    //Main method is the entry point into our application
    // if there are more than one Main function defined we will get an error  Program has more than one entry point defined
    public static void Main()
    {
        /* You can declare identifiers that match C# keywords by using the @ prefix on the identifier. 
        The @ is not part of the identifier name. For example, @if declares an identifier named if.*/

        int @if = 123;
        Console.WriteLine(@if);

        Console.WriteLine("Hello World");
    }
}