using System.Collections.Generic;
using BasicCommand;
using Zenject;

namespace ActorCommand
{
    public class ActorCommandExecutor : ICommandExecutor<ICommand>, ITickable
    {
        private Queue<ICommand> _commandsQueue = new();
        
        public void ExecuteCommand()
        {
            if (_commandsQueue.TryDequeue(out var command))
            {
                command.Execute();
            }
        }

        public void PushCommand(ICommand command)
        {
            _commandsQueue.Enqueue(command);
        }

        public void Tick()
        {
            if (_commandsQueue.Count > 0)
            {
                ExecuteCommand();
            }
        }
    }
}