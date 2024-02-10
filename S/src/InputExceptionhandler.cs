namespace SingleResponsibilityPrinciple;

using System;

public class InputExceptionhandler
{
    public void handleException(Exception ex)
    {
        Console.WriteLine($"Error {ex.Message}");
        Console.WriteLine("Please try again.");
    }    
}