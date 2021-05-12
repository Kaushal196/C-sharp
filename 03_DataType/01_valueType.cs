/*
A data type is a value type if it 
holds a data value within its own memory space. 
It means the variables of these data types directly contain values.
int i = 100;

() indicates suffix
types-
bool
byte
char
decimal (m)
double  (d)
enum    
float   (f)
int   32-bit signed integer
long    (l)
sbyte
short
struct
uint   (u)
ulong  (ul)
ushort
*/

using System;
class Program {
    static void Main() {

        int intVar = 100;
        float floatVar = 10.2f;
        char charVar = 'A';
        bool boolVar = true;
        Console.WriteLine("intVar= {0}, floatVar= {1}, charVar= {2}, boolVar= {3}",intVar, floatVar, charVar, boolVar);
        //op - intVar= 100, floatVar= 10.2, charVar= A, boolVar= True
        /*
        When we pass value type data to another function then it will pass a copy of that so any modifcation in any
        other function will not affect current value
        */ 
    }
}