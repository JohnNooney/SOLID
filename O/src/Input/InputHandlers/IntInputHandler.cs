namespace OpenClosePrinciple;

using System;

public class IntInputHandler : InputHandler
{
    public IntInputHandler(InputValidator validator, InputExceptionHandler exceptionHandler) : base(validator, exceptionHandler)
    { 
        // call base constructor
    }

    protected override void CollectInput()
    {
        try
        {
            Input.IntInput = int.Parse(Console.ReadLine());
        }
        catch(Exception ex)
        {
            ExceptionHandler.handleException(ex);
        }
    }

    protected override void CheckInputValidity()
    {
        if(!Validator.isIntValid(Input))
        {
            CollectValidInput();
        }
    }
}