namespace ActorCommand
{
    public class JumpCommand : ICommand
    {
        public IActor Actor { get; }

        public JumpCommand(IActor actor)
        {
            Actor = actor;
        }
        
        public void Execute()
        {
            Actor.Jump();
        }
    }
}