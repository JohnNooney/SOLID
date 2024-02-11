namespace OpenClosePrinciple;

using System;

public class StringOutputHandler : OutputHandler
{
    public override void Output(Output output)
    {
        Console.WriteLine(output.StringOutput);
    }
}