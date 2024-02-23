# Dependancy Inversion Principle
This principle states that high-level modules, which provide complex logic, should be easily reusable and unaffected by changes in low-level modules, which provide utility features.

## Program Requirements
* CLI program 
* a Server creates text files
* a Client gets notified if a file was created for them
   * A message gets output to the console that a file was created
   * The file is read by the client and the contents are outputted to the console
   * After a file is read it is copied to the clients directory

## Implementation Details
In order to read and write files we need to make use of the of the `StreamWriter`, `StreamReader` and `FileStream` APIs.

The `StreamWriter`, `StreamReader` and `FileStream` APIs should all be considered low-level modules so by abstracting them into seperate classes, we can reverse the control of depency on those libraries.

This program abstracts the aforementioned APIs into the `FileReader` and `FileCreator` classes.

