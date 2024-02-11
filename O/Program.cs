namespace OpenClosePrinciple;

class Program
{
    private static InputOutput stringIO;
    private static InputOutputBuilder ioBuilder;
    private static InputOutputDirector ioDirector;
    private static Output consoleOutput;

    static Program()
    {
        initIO();
        createStringIO();
    }

    static void Main(string[] args)
    {
        consoleOutput.StringOutput = "Hello There";

        stringIO.Output(consoleOutput);
        stringIO.Input();
        stringIO.EchoInput();
    }

    private static void initIO()
    {
        ioBuilder = new InputOutputBuilder();
        ioDirector = new InputOutputDirector
        {
            builder = ioBuilder
        };
        
        consoleOutput = new Output();
    }

    private static void createStringIO()
    {
        ioDirector.BuildStringIO();

        stringIO = ioBuilder.GetInputOutput();
    }
}
