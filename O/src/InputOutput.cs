namespace OpenClosePrinciple;

public class InputOutput : IInputOutput
{
    protected OutputHandler outputHandler;
    protected InputHandler inputHandler;

    public InputOutput(InputHandler inputHandler, OutputHandler outputHandler)
    {
        this.outputHandler = outputHandler;
        this.inputHandler = inputHandler;
    }

    public void Output(Output output)
    {
        outputHandler.Output(output);
    }

    public void Input()
    {
        inputHandler.CollectValidInput();
    }

    public void EchoInput()
    {
        Output output = inputToOutput(inputHandler.Input);
        outputHandler.Output(output);
    }

    private Output inputToOutput(Input input)
    {

        Output output = new Output{
            IntOutput = input.IntInput,
            StringOutput = input.StringInput,
            DoubleOutput = input.DoubleInput,
        };

        return output;
    }
    
}
