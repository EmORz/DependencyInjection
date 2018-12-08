using System;
using System.IO;
using EmoTrainWithCrazyApp.Models.Contracts;

namespace EmoTrainWithCrazyApp.Models
{
    public class FileWriter: IWrite
    {
        private const string path = "textBank.txt";

        public void Write(string text)
        {
            File.AppendAllText(path, text+Environment.NewLine);
        }
    }
}