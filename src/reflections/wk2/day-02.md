<!-- What are the three ways to syntactically write a function? What are the differences in how the function acts (if any)? -->

A Function Declaration -
    When using function declarations, the function definition is hoisted, thus allowing the function to be used before it is defined.
 Function Expressions -
        Function Expressions are not hoisted, and therefore cannot be used before they are defined.
Arrow Function Expression -
    Arrow functions do not create their own 'this' value.

<!-- What is the difference between Parameters and Arguments? -->

Parameters are used when defining a function and are the names created in the function definition.
Arguments are the values the function receives from each parameter when the function is invoked.


<!-- What are higher order functions? Can you provide an example? -->

When a function accepts another function as a parameter, or returns a function, it is called a higher-order function. Array.prototype.map and Array.prototype.filter are higher order functions.
