using System;

namespace RockPaperScissors.App;
public class InputOut
{
    public void Output(string s)
    {
        Console.WriteLine(s);
    }

    public string Input()
    {
        return Console.ReadLine();
    }
}
