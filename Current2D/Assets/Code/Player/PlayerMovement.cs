// ACTION MAP !! currently bound to work with my weird controller, will need to be updated to work with XBox, etc.

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;
using System.Numerics;

public class PlayerMovement : MonoBehaviour
{
    private int tileSize = 1; // moves one "tile" per button press
    private LayerMask stopsMovementLayer; // things on this layer will stop player movement
    PlayerControl controls; // the action map used to access controller input

    void Awake()
    {
        stopsMovementLayer = LayerMask.GetMask("StopsPlayerMovement");

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
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), stopsMovementLayer))
        {
            transform.position += new UnityEngine.Vector3(0f, tileSize, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveDown()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), stopsMovementLayer))
        {
            transform.position -= new UnityEngine.Vector3(0f, tileSize, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveLeft()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), stopsMovementLayer))
        {
            transform.position -= new UnityEngine.Vector3(tileSize, 0f, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }

    void MoveRight()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), stopsMovementLayer))
        {
            transform.position += new UnityEngine.Vector3(tileSize, 0f, 0f);
        }
        else
        {
            Debug.Log("A wall was hit");
        }
    }
}
