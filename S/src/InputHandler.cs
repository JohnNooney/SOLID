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
    
    public void collectStringInput()
    {   
        try
        {
            getValidInput();
        }
        catch(Exception ex)
        {
            exceptionHandler.handleException(ex);
        }
    }

    public string getStringInput()
    {
        return stringInput;
    }

    private void getValidInput()
    {
        stringInput = Console.ReadLine();

        if(!validator.isStringValid(stringInput))
        {
            
        }
    }
}