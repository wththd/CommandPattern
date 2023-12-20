namespace BasicCommand
{
    public interface ICommandExecutor<T>
    {
        void ExecuteCommand();
        void PushCommand(T command);
    }
}