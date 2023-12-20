using Zenject;

namespace BasicCommand
{
    public class BasicCommandExecutor : ICommandExecutor<ICommand>, ITickable
    {
        private ICommand _currentCommand;
        
        public void ExecuteCommand()
        {
            _currentCommand.Execute();
        }

        public void PushCommand(ICommand command)
        {
            _currentCommand = command;
        }

        public void Tick()
        {
            if (_currentCommand != null)
            {
                ExecuteCommand();
                _currentCommand = null;
            }
        }
    }
}