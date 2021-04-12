# C# Fundamentals


**1.** What is the purpose of a `namespace`?
<!-- enter you answer in the space below -->
```
The purpose of namespace is to give the file a name to be looekd up by when being imported by other files.

```
**2.** What is the difference between a `class` and a `struct`?
<!-- enter you answer in the space below -->
```
A class combines the fields and methods into a single unit. A structure is a collection of variables of different data types under a single unit.
```
**3.** What is the method that returns an instance of a class, yet it has no return type?
<!-- enter you answer in the space below -->
```
'abstract'. It allows 'incomplete' methods to be returned without being instantiated. 
```
## Example 1
```c#
abstract class Car
{
  ...
  public virtual string Start()
  {
    return "Vroooom";
  }
}
```
**5.** In the example what is the access modifier of the `Start()` method?
<!-- enter you answer in the space below -->
```
'public'.

```
**6.** In the example what is `string` an indication of?
<!-- enter you answer in the space below -->
```
It is an indication of what Start() is returning.
So in this case, it would be the string; 'Vroooom'.
```
**7.** In the example what is `abstract` preventing?
<!-- enter you answer in the space below -->
```
Abstract is preventing the class Car from needed to be instantiated 
```
**8.** In the example what is the purpose of `virtual`?
<!-- enter you answer in the space below -->
```
The purpose of 'virtual' is to provide the derived classes with the option of overriding it.
```
**9.** Name four access modifiers:
<!-- enter you answer in the space below -->
```
private,
public,
protected,
internal 
```
**10.** If you set a class or method to private, what can access it?
<!-- enter you answer in the space below -->
```
Only the local user. 

```