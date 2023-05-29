using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction turnAction;

    public float moveSpeed = 10.0f;
    public float turnSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
        turnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
    }

    /// <summary>
    /// Moves the player on the horizontal axis.
    /// </summary>
    private void Move()
    {
        var moveDirection = moveAction.ReadValue<float>();
        Vector3 V3MoveDirection = transform.right * moveDirection;
        //Debug.Log(moveDirection);
        transform.position += V3MoveDirection * moveSpeed * Time.deltaTime;
    }

    /// <summary>
    /// Changes the players Y value to turn the tank.
    /// </summary>
    private void Turn()
    {
        var turnDirection = turnAction.ReadValue<float>();
        Vector3 V3TurnDirection = new Vector3(0.0f, turnDirection, 0.0f);
        //Debug.Log(turnDirection);
        transform.Rotate(V3TurnDirection);
    }
}
