Read Foundations of C# > C# Enum's and answer the following questions

What is an Enum, and what are some use cases for them?
``
Enums are strongly typed constants. They are essentially unique types that allow you to assign symbolic names to integral values. In the C# tradition, they are strongly typed. That means an enum of one type may not be implicitly assigned to an enum of another type, though the underlying value of their members is the same.
``

How can you modify an Enum?
``
You can modify an Enum by changing the set value. By default, the first member of an enum takes the value of zero. If this value doesn't make sense for your enum, you can change it to one or some other number. Additionally, you can change any of the members of an enum to any value that is valid for its base type.

``

How have you used Enums in your afternoon lab projects this far?(if you have not yet, give an example of how you could)
``
You can use Enums to define constants values.
I used them to give Knights and Castles values, such as name, age ect.
``