namespace OpenClosePrinciple;

using System;

public class InputValidator
{
    private bool validity;
    public bool isStringValid(Input input)
    {
        validity = !string.IsNullOrEmpty(input.StringInput);
        
        if(!validity)
        {
            Console.WriteLine("String Input is invalid. Pleas try again.");
        }

        return validity;
    }

    public bool isIntValid(Input input)
    {
        validity = input.IntInput != null;
        
        if(!validity)
        {
            Console.WriteLine("Int Input is invalid. Pleas try again.");
        }

        return validity;
    }
}