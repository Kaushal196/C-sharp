/*
A value type variable cannot be null because it holds value, not a memory address. C# 2.0 introduced nullable types, using which you can assign null to a value type variable or declare a value type variable without assigning a value to it.


Nullable<T> type allows assignment of null to value types.
? operator is a shorthand syntax for Nullable types.
Use value property to get the value of nullable type.
Use HasValue property to check whether value is assigned to nullable type or not.
Static Nullable class is a helper class to compare nullable types.

You can only use == and != operators with a nullable type. For other comparison use the Nullable static class.
*/
using System;
class Program {
    static void Main() {
        //int i = null compile error
        
        Nullable<int> i = null;   //no error
        //A nullable type can represent the correct range of values for its underlying value type, plus an additional null value.

        //we can use HasValue to check nullable var has any value or not
        if (i.HasValue)
            Console.WriteLine(i.Value); // or Console.WriteLine(i)
        else
            Console.WriteLine("Null");
        //op - Null

        //-------------------------------------------------------------------------------
        // We can not access value directly if value is null
        Nullable<int> j = null;
        //Console.WriteLine(j.Value);
        //error  System.InvalidOperationException: Nullable object must have a value.
        Console.WriteLine(j.GetValueOrDefault());
        //op prints value if not null, else print default value
        // for this example op = 0 

        //-----------------------------------------------------------------------------
        //Shortcut
        int? k = null;
        int l = k ?? 0; //Use the '??' operator to assign a nullable type to a non-nullable type.


        //-----------------------------------------------------------------------------
        int? m = null;
        int n = 10;

        if (Nullable.Compare<int>(m, n) < 0)
            Console.WriteLine("m < n");
        else if (Nullable.Compare<int>(m, n) > 0)
            Console.WriteLine("m > n");
        else
            Console.WriteLine("m = n");

        //op- m < n

    }
}