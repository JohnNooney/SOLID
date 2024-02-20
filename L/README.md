# Liskov Subsitution Principle
This principle states functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.


## Program Requirements
* CLI program 
* Prompts user for generating a shape
    * Asks for dimensions
* Collects user input
* Outputs shape's dimensions


## Implementation Details
From an implementation perspective, this program uses a subclassing strategy where all shapes, circle, square, rectangle,  inherit from a common `Shape` abstract class.

The `Shape` class is used in a factory pattern to create different shapes based on the user's input. The factory pattern would use the base class type to generalize the creation the child classes - thus proving LSP.  

