// ACTION MAP !! currently bound to work with my weird controller, will need to be updated to work with XBox, etc.

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;
using System.Numerics;

public class PlayerMovement : MonoBehaviour
{
    private float moveDistance = 1f; // moves one "tile" per button press

    public LayerMask whatStopsMovement; // things on this layer will stop player movement

    PlayerControl controls; // the action map used to access controller input

    void Awake()
    {
        controls = new PlayerControl();

        controls.PlayerMoveInputs.PlayerMoveUp.performed += context => MoveUp();
        controls.PlayerMoveInputs.PlayerMoveDown.performed += context => MoveDown();
        controls.PlayerMoveInputs.PlayerMoveLeft.performed += context => MoveLeft();
        controls.PlayerMoveInputs.PlayerMoveRight.performed += context => MoveRight();
    }

    void OnEnable()
    {
        controls.PlayerMoveInputs.Enable();
    }

    void OnDisable()
    {
        controls.PlayerMoveInputs.Disable();
    }

    void MoveUp()
    {
        Debug.Log("D-Pad up pressed");

        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + moveDistance), whatStopsMovement))
        {
            transform.position += new UnityEngine.Vector3(0f, moveDistance, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveDown()
    {
        Debug.Log("D-Pad down pressed");

        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - moveDistance), whatStopsMovement))
        {
            transform.position -= new UnityEngine.Vector3(0f, moveDistance, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveLeft()
    {
        Debug.Log("D-Pad left pressed");

        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - moveDistance, transform.position.y), whatStopsMovement))
        {
            transform.position -= new UnityEngine.Vector3(moveDistance, 0f, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveRight()
    {
        Debug.Log("D-Pad right pressed");

        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + moveDistance, transform.position.y), whatStopsMovement))
        {
            transform.position += new UnityEngine.Vector3(moveDistance, 0f, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }
}
