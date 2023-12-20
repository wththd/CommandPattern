using UnityEngine;

namespace Shared
{
    public static class UnityButtonTypeHelper
    {
        public static KeyCode ToKeyCode(this ButtonType type)
        {
            switch (type)
            {
                case ButtonType.Jump:
                    return KeyCode.Space;
                case ButtonType.Move:
                    return KeyCode.Mouse1;
                case ButtonType.Fire:
                    return KeyCode.Mouse0;
                case ButtonType.None:
                default:
                    return KeyCode.None;
            }
        }
    }
}