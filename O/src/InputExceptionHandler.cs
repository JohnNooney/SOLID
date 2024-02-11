namespace OpenClosePrinciple;

using System;

public class InputExceptionHandler
{
    public void handleException(Exception ex)
    {
        Console.WriteLine($"Error {ex.Message}");
        Console.WriteLine("Please try again.");
    }    
}