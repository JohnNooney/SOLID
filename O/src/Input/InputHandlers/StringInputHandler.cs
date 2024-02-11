namespace OpenClosePrinciple;

using System;

public class StringInputHandler : InputHandler
{
    public StringInputHandler(InputValidator validator, InputExceptionHandler exceptionHandler) : base(validator, exceptionHandler)
    { 
        // call base constructor
    }

    protected override void CollectInput()
    {
        try
        {
            Input.StringInput = Console.ReadLine();
        }
        catch(Exception ex)
        {
            ExceptionHandler.handleException(ex);
        }
    }

    protected override void CheckInputValidity()
    {
        if(!Validator.isStringValid(Input))
        {
            CollectValidInput();
        }
    }
}