namespace BasicCommand
{
    public class JumpBasicCommand : ICommand
    {
        public void Execute()
        {
            Player.Instance.DoJump();
        }
    }
}