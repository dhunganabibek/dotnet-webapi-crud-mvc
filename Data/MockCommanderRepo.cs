using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data{

    public class MockCommanderRepo : ICommanderRepo
    {
        IEnumerable<Command> ICommanderRepo.GetAppCommands()
        {
            var commands = new List<Command>(){
                new Command {Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command {Id=1, HowTo="Boil a Potato", Line="Heater", Platform="Choppong Board"},
                new Command {Id=2, HowTo="Cook Food", Line="watch Videos", Platform="Practice Demo"}
            };
            return commands;
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"};
        }
    }
}