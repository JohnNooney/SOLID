namespace OpenClosePrinciple;

using System;

public class IntOutputHandler : OutputHandler
{
    public override void Output(Output output)
    {
        Console.WriteLine(output.IntOutput);
    }
}