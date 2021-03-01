What are the three states of a Promise?
``
Pending: Initial State, before the Promise succeeds or fails
Resolved: Completed Promise
Rejected: Failed Promise

``





How do promises seek to resolve the issues of "callback hell"?
``
Using 'Chaining', which is how multiple callbacks can be chained one after another, which is attatching callbacks rather than passing them.

``



What is the difference between .then() and .catch()?
``
The then( ) method is only for resolved Promises, if the promise gets rejected, it will jump to the catch( ) method.

``