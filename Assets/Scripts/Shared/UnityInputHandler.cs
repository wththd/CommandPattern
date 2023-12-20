using UnityEngine;

namespace Shared
{
    public class UnityInputHandler : IInputHandler
    {
        public bool IsButtonDown(ButtonType type)
        {
            var button = type.ToKeyCode();
            if (button == KeyCode.None)
            {
                return Input.anyKey;
            }
            
            return Input.GetKeyDown(button);
        }

        public bool IsButtonPressed(ButtonType type)
        {
            var button = type.ToKeyCode();
            if (button == KeyCode.None)
            {
                return Input.anyKey;
            }
            
            return Input.GetKey(button);
        }

        public bool IsButtonUp(ButtonType type)
        {
            var button = type.ToKeyCode();
            if (button == KeyCode.None)
            {
                return Input.anyKey;
            }
            
            return Input.GetKeyUp(button);
        }
    }
}