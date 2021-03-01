What are some of the signs and causes of Callback Hell?
``
    A bunch of ')}' at the end of code.
``




What does the asynchronous mean and how are callbacks involved?
``
The word 'asynchronous', aka 'async' just means 'takes some time' or 'happens in the future, not right now'. Usually callbacks are only used when doing I/O, e.g. downloading things, reading files, talking to databases, etc.
``





Summarize the 3 ways to avoid / fix Callback Hell

``
Keep your code shallow
    makes code easier to read thanks to the descriptive function names
when exceptions happen you will get stacktraces that reference actual function names instead of "anonymous"
allows you to move the functions and reference them by their names

Modularize
    "Write small modules that each do one thing, and assemble them into other modules that do a bigger thing. You can't get into callback hell if you don't go there."

Handle every single error
    Don't nest functions. Give them names and place them at the top level of your program
    Use function hoisting (opens new window)to your advantage to move functions 'below the fold'

``