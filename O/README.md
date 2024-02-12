# Open/Close Principle
This principle states a module should be open to extension but closed to modification.

## Program Requirements
* CLI program 
* Outputs a prompt
* Collects user input
    * input is validated for being null or empty
    * if validation fails prompt user to re-try input
* Prints user input back


## Implementation Details
From an implementation perspective, this program will build on top of the program implemented in the Single Responsibility Principle by refactoring the code to follow the OCP.

Class Changes:
- `InputOutput` is now generalized to take an input and output handler as dependencies and will create an I/O object based on the injected dependencies
- Refactored the `InputHandler` to be a abstract hbase class where child classes can extend the functionality of the program by having the option of handling different Input Types.
- Refactored the `OutputHandler` for the same reasons as the `InputHandler`.
- Followed a builder pattern to so that a builder and director can be in control of different `InputOutput` objects.

