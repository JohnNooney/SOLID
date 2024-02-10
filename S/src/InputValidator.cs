using System.Runtime.CompilerServices;

namespace SingleResponsibilityPrinciple;

using System;

public class InputValidator
{
    private bool validity;
    public bool isStringValid(string input)
    {
        validity = !string.IsNullOrEmpty(input);
        
        if(!validity)
        {
            Console.WriteLine("Input is invalid.");
        }

        return validity;
    }
}