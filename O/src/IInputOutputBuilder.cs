namespace OpenClosePrinciple;

public interface IInputOutputBuilder
{
    void BuildStringOutputHandler();
    void BuildStringInputHandler();
    void BuildInputExceptionHandler();
    void BuildInputValidator();
    void BuildInputOutput();
}