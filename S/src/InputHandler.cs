namespace SingleResponsibilityPrinciple;

using System;

public class InputHandler
{
    private readonly InputValidator validator;
    private readonly InputExceptionHandler exceptionHandler;
    private string stringInput;

    public InputHandler(InputValidator validator, InputExceptionHandler exceptionHandler)
    {
        this.validator = validator;
        this.exceptionHandler = exceptionHandler;
        stringInput = "";
    }

    public string getStringInput()
    {
        return stringInput;
    }
    
    public void collectValidStringInput()
    {   
        collectStringInput();
        checkStringValidity();
    }

    private void collectStringInput()
    {
        try
        {
            stringInput = Console.ReadLine();
        }
        catch(Exception ex)
        {
            exceptionHandler.handleException(ex);
        }
    }

    private void checkStringValidity()
    {
        if(!validator.isStringValid(stringInput))
        {
            collectValidStringInput();
        }
    }
}