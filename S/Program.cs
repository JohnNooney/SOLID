namespace SingleResponsibilityPrinciple;

using System;

class Program
{ 
    static void Main(string[] args)
    {
        InputOutput io = new InputOutput();

        io.output("Hello There");
        io.input();
        io.echoInput();
    }
}
