namespace BasicCommand
{
    public class MoveBasicCommand : ICommand
    {
        public void Execute()
        {
            Player.Instance.DoMove();
        }
    }
}