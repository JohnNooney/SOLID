namespace OpenClosePrinciple;

using System;
using System.Runtime.InteropServices.Marshalling;

public abstract class InputHandler : IInputHandler
{
    public Input Input {get; set;}

    protected readonly InputValidator Validator;
    protected readonly InputExceptionHandler ExceptionHandler;

    public InputHandler(InputValidator validator, InputExceptionHandler exceptionHandler)
    {
        Validator = validator;
        ExceptionHandler = exceptionHandler;

        Input = new Input();
    }
    
    public virtual void CollectValidInput()
    {   
        CollectInput();
        CheckInputValidity();
    }

    protected abstract void CollectInput();

    protected abstract void CheckInputValidity();
}