# Single Responsibility Principle
This principle states a module should only have one responsibility.

## Program Requirements
* CLI program 
* Outputs a prompt
* Collects user input
    * input is validated for being null or empty
    * if validation fails prompt user to re-try input
* Prints user input back


## Implementation Details
From an implementation perspective, this program will demonstrate the Single Responsibility Principle through the use of classes and methods.

Class Descriptions:
- `InputOutput.cs` -  Instantiates the input and output handlers and exposes input/output functionality
- `InputHandler.cs` - Handles the collection of input from the console. Relies on `InputValidator` and `InputExeceptionHandler` to make sure input is collected without error.
- `OutputHandler.cs` - Handles the output of a string to the console.
- `InputValidator.cs` - Performs a check on the collected input to make sure it's not Empty or Null. Will prompt to try again if invalid.
- `InputExceptionHandler.cs` - Handles any exceptions encountered during input collection. Will print the error and prompt to try again.
