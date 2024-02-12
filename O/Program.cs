namespace OpenClosePrinciple;

class Program
{
    private static InputOutput stringIO;
    private static InputOutput intIO;
    private static InputOutputBuilder ioBuilder;
    private static InputOutputDirector ioDirector;
    private static Output consoleOutput;

    static Program()
    {
        initIO();
        createStringIO();
        createIntIO();
    }

    static void Main(string[] args)
    {
        consoleOutput.StringOutput = "Hello There";

        stringIO.Output(consoleOutput);
        stringIO.Input();
        stringIO.EchoInput();

        consoleOutput.StringOutput = "Enter a number:";

        stringIO.Output(consoleOutput);
        intIO.Input();
        intIO.EchoInput();
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

    private static void createIntIO()
    {
        ioDirector.BuildIntIO();

        intIO = ioBuilder.GetInputOutput();
    }
}
