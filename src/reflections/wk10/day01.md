Read Foundations of C# > C# Data Types and answer the following questions
What are the three categories of data types? How are they different?
``
Value type
    - A data type is a value type if it holds a data value within its own memory space. It means the variables of these data types directly contain values.
Reference type
    - Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the data.
Pointer type
    - Pointer types do not inherit from object and no conversions exist between pointer types and object.
`` 


What are the Value-type data types? What differences do you notice from JavaScript?
``
bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort.
I noticed that there is no 'let', or 'var'. 
``


In your own words how do Reference types get stored in memory? How does this differ from Value types?
``
Reference Types store data in its memory using a numerical value. It then directly references the numerical value to gather the data.
``