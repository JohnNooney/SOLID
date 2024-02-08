namespace SingleResponsibilityPrinciple;

using System;

class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Starting Spinners...");

        Spinner spinner = new Spinner(0, 3);
        Spinner spinner2 = new Spinner(1, 3);
        Spinner spinner3 = new Spinner(2, 3);
        
        spinner.start();
        spinner2.start();
        spinner3.start();

        Thread.Sleep(10000);

        spinner.stop();
        spinner2.stop();
        spinner3.stop();
        
    }
}
