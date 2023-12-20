namespace BasicCommand
{
    public class RotateBasicCommand : ICommand
    {
        public void Execute()
        {
            Player.Instance.DoFire();
        }
    }
}