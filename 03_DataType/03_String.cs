/* Note
String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location. So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be reflected in the original value, as shown below.
*/
using System;
class Program {
    
    static void ChangeReferenceType(string name)
    {
        name = "Steve";
    }
    static void Main() {
        string name = "Test String";
        ChangeReferenceType(name);
        Console.WriteLine(name);
        //op- Test String
    }
    
}