using EmoTrainWithCrazyApp.Models.Contracts;
using SoftUniDi.Attributes;

namespace EmoTrainWithCrazyApp.Core
{
    public class Engine : IEngine
    {
        [Inject]
        private IRead reader;

        [Inject]
        [Named("ConsoleWriter")]
        private IWrite consoleWriter;

        [Inject]
        [Named("FileWriter")]
        private IWrite fileWriter;

        public Engine(IWrite fileWriter, IRead consoleReader, IWrite consoleWriter)
        {
            this.fileWriter = fileWriter;
            this.consoleWriter = consoleWriter;
            this.reader = consoleReader;

        }
        public void Run()
        {
            var readInput = this.reader.Read();
            this.consoleWriter.Write(readInput);
            this.fileWriter.Write(readInput);

        }
    }
}