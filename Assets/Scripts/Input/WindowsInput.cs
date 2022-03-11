using UnityEngine;

namespace Input
{
    public class WindowsInput : IInput
    {
        public Vector2 MoveDirection =>
            new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical")).normalized;
    }
}
