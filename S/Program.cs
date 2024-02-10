namespace SingleResponsibilityPrinciple;

using System;

class Program
{ 
    static void Main(string[] args)
    {
        OutputHandler outputHandler = new OutputHandler();
        InputValidator inputValidator = new InputValidator();
        InputHandler inputHandler = new InputHandler(inputValidator);

        outputHandler.outputString("Enter something!");
        inputHandler.collectStringInput();

        outputHandler.outputString(inputHandler.getStringInput());        
    }
}
