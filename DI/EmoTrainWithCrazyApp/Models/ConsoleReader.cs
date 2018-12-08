using System;
using EmoTrainWithCrazyApp.Models.Contracts;

namespace EmoTrainWithCrazyApp.Models
{
    public class ConsoleReader : IRead
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}