namespace Shared
{
    public interface IInputHandler
    {
        bool IsButtonDown(ButtonType type);
        bool IsButtonPressed(ButtonType type);
        bool IsButtonUp(ButtonType type);
    }
}