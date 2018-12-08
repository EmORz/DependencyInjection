using EmoTrainWithCrazyApp.Models.Contracts;
using System;

namespace EmoTrainWithCrazyApp.Models
{
    public class ConsoleWriter : IWrite
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
