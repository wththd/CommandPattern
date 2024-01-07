namespace ActorCommand
{
    public interface ICommand
    {
        IActor Actor { get; }
        void Execute();
    }
}