/*
 a reference type contains a pointer to another memory location that holds the data.
 String
 Arrays (even if their elements are value types)
 Class
 Delegate

 The default value of a reference type variable is null when they are not initialized
*/
using System;
class Program {

    
}

/* Note
String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location. So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be reflected in the original value, as shown below.
*/