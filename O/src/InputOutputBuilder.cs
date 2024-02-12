namespace OpenClosePrinciple;

public class InputOutputBuilder: IInputOutputBuilder
{
    private InputOutput io;
    private InputValidator validator;
    private InputExceptionHandler exceptionHandler;
    private InputHandler inputHandler;
    private OutputHandler outputHandler;

    public void BuildInputValidator()
    {
        validator = new InputValidator();
    }

    public void BuildInputExceptionHandler()
    {
        exceptionHandler = new InputExceptionHandler();
    }

    public void BuildStringInputHandler()
    {
        inputHandler = new StringInputHandler(validator, exceptionHandler);
    }

    public void BuildStringOutputHandler()
    {
        
        outputHandler = new StringOutputHandler();
    }

    public void BuildIntInputHandler()
    {
        inputHandler = new IntInputHandler(validator, exceptionHandler);
    }

    public void BuildIntOutputHandler()
    {
        
        outputHandler = new IntOutputHandler();
    }

    public void BuildInputOutput()
    {
        io = new InputOutput(inputHandler, outputHandler);
    }

    public InputOutput GetInputOutput()
    {
        return io;
    }
}