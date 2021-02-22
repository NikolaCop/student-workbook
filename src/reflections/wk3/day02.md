<!-- What is the purpose of Encapsulation? -->

 The purpose of Encapsulation is that an object stores its state privately, and only the object's methods have access to change it. Meaning, it keeps it restricted.



<!-- What were some of the problems with closures and the underscore prefix? -->

Breaking Changes: Internal properties and methods tend to change more frequently than public properties and methods. For many, underscore prefixed methods, refer to methods that they do not intend users of the API to call directly. Instead, they're used only internally, and as such, if their implementations change, or if they're entirely deleted, those developers would not consider that to be a breaking change.


<!-- How do we create private variables in a ES6 Class? Why would you do this? -->

You can create private variables with babel and with the stage-3 preset enabled. You would do this to keep your programs from being edited by an outside source.

<!-- afternoon project -->
