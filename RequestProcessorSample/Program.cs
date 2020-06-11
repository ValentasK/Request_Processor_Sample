using System;

namespace RequestProcessorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            InputProcessor input = new InputProcessor(); // new object of InputProcessor classs
            input.PreventSLetter();
            input.PreventEvenNumbers();
            input.SetResponceTo10CharsOfInput();
            input.Process();
        }
    }
}
