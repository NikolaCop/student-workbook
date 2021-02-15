# Intro to JavaScript

**1.** Which keywords are used to declare a variable in JavaScript?
<!-- enter you answer in the space below -->
```
let, const, and var.

```
**2.** What is the definition of a function?
<!-- enter you answer in the space below -->
``` 
A set of statements that performs a task or calculates a value.

```
**3.** What are the `SOLID` principles?
<!-- enter you answer in the space below -->
```
Single-responsibility principle, Open–closed principle,
Liskov substitution principle, Interface segregation principle,
Dependency inversion principle.
```
**4.** Given this array: 
```js
let fruit = ['apple', 'banana', 'pineapple',  'orange', 'strawberry']
``` 
What index is the pineapple's current position? How do you know?
<!-- enter you answer in the space below -->
```
Pineapple is at index 2, because indexs start at 0.

```
**5.** With these two objects: 
```js
let you = { name:"You", hair: true, friends: [] }
let them = { name:"Them", hair: false, friends: [] }
```
how would you .push the `them` object into the `you` object's array of friends?
<!-- enter you answer in the space below -->
```
you.push( name:"Them", hair: false, friends: [] );
```

**6.** Give an example of a JavaScript `Conditional`:
<!-- enter you answer in the space below -->
```
if(isSnowing = true){
  console.log("It is snowing")
}
```
**7.** In the `for loop` below, what is the name of the piece belongs inside the empty "______" space? What would you put here to increase `i` by one on every iteration?
```js
for ( let i = 0; i < arr.length; _______ ) {
  //...
```
<!-- enter you answer in the space below -->
```
The missing piece is called the 'incrementor' - to increase by 1, you can do 'i++'.
```
**8.** What does the `DOM` acronym stand for? Which file is first accessed to render the `DOM`?
<!-- enter you answer in the space below -->
```
 "Document Object Mode" - the first file accessed is index.html
```

**9.** What are the `9` ECMAScript types as defined by MDN?
<!-- enter you answer in the space below -->
```
Undefined, Boolean, Number, String, BigInt, Symbol, Object, Function and Null.
```
**10.** When it comes to functions or methods, what is the difference between a `parameter` and an `argument`?
<!-- enter you answer in the space below -->
```
Parameters are used when defining a function and are the names created in the function definition.
Arguments are the values the function receives from each parameter when the function is invoked.

```
**11.** What is the difference between a `primitive` value and a `reference` value?
<!-- enter you answer in the space below -->
```
Primitive values are data that are stored on the stack, Reference values are objects that are stored in the heap.
```