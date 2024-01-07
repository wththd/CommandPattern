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
                case ButtonType.None:
                default:
                    return KeyCode.None;
            }
        }
    }
}