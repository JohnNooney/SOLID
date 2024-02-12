using System.Security.Cryptography.X509Certificates;

namespace OpenClosePrinciple;

public class InputOutputDirector{

    private InputOutputBuilder _builder;
    public InputOutputBuilder builder {
        set {_builder = value; }
    }

    public void BuildStringIO()
    {
        _builder.BuildInputExceptionHandler();
        _builder.BuildInputValidator();
        _builder.BuildStringInputHandler();
        _builder.BuildStringOutputHandler();
        _builder.BuildInputOutput();
    }

    public void BuildIntIO()
    {
        _builder.BuildInputExceptionHandler();
        _builder.BuildInputValidator();
        _builder.BuildIntInputHandler();
        _builder.BuildIntOutputHandler();
        _builder.BuildInputOutput();
    }
}