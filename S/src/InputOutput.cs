namespace SingleResponsibilityPrinciple;

using System;

public class InputOutput
{
    private OutputHandler outputHandler;
    private InputValidator inputValidator;
    private InputExceptionHandler exceptionHandler;
    private InputHandler inputHandler;

    public InputOutput()
    {
        outputHandler = new OutputHandler();
        inputValidator = new InputValidator();
        exceptionHandler = new InputExceptionHandler();
        inputHandler = new InputHandler(inputValidator, exceptionHandler);
    }

    public void output(string output)
    {
        outputHandler.outputString(output);
    }

    public void input()
    {
        inputHandler.collectValidStringInput();
    }

    public void echoInput()
    {
        outputHandler.outputString(inputHandler.getStringInput());
    }

    
}
