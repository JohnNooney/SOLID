namespace OpenClosePrinciple;

public interface IInputHandler
{
    Input Input {get; set;}
    void CollectValidInput();

}