namespace SingleResponsibilityPrinciple;

using System;

public class Spinner : IDisposable
{
    private const string Sequence = "/-\\|";
    private int counter = 0;
    private bool active;
    private readonly int delay;
    private readonly int left;
    private readonly int top;
    private readonly Thread thread;

    public Spinner(int left, int top, int delay = 100)
    {
        this.left = left;
        this.top = top;
        this.delay = delay;
        thread = new Thread(spin);
    }

    public void start()
    {
        active = true;
        if(!thread.IsAlive)
        {
            thread.Start();
        }
    }

    public void stop()
    {
        active = false;
    }

    private void spin()
    {
        while(active)
        {
            turn();
            Thread.Sleep(delay);
        }
    }

    private void turn()
    {
        int currentSymbolIndex = ++counter;

        char topSymbol = Sequence[ currentSymbolIndex % Sequence.Length];
        char middleSymbol = Sequence[ (currentSymbolIndex + 1) % Sequence.Length];
        char bottomSymbol = Sequence[ (currentSymbolIndex + 2) % Sequence.Length];
        
        draw(topSymbol);
        draw(middleSymbol, 1);
        draw(bottomSymbol, 2);
    }

    private void draw(char symbol, int topOffset = 0)
    {
        Console.SetCursorPosition(left, top + topOffset);
        Console.Write(symbol);
    }

    public void Dispose()
    {
        stop();
    }

}