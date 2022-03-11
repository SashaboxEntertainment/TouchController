using Input;
using UnityEngine;
using Zenject;

public class PlayerMovement : MonoBehaviour
{
    private IInput _input;

    [Inject]
    private void Init(IInput input)
    {
        _input = input;
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 moveDirection = _input.MoveDirection;
    }
}
