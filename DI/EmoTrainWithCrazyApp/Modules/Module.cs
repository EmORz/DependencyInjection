using EmoTrainWithCrazyApp.Models;
using EmoTrainWithCrazyApp.Models.Contracts;
using SoftUniDi.Modules;

namespace EmoTrainWithCrazyApp.Modules
{
    public class Module: AbstractModule
    {
        public override void Configure()
        {
            this.CreateMapping<IRead, ConsoleReader>();
            this.CreateMapping<IWrite, ConsoleWriter>();
            this.CreateMapping<IWrite, FileWriter>();
        }
    }
}