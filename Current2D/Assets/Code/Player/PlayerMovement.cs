// ACTION MAP !! currently bound to work with my weird controller, will need to be updated to work with XBox, etc.

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;
using System.Numerics;
using UnityEditor;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    float tileSize = 0.5F; // moves one "tile" per button press
    private LayerMask stopsMovementLayer; // things on this layer will stop player movement
    public PlayerControl controls; // the action map used to access controller input

    private AudioSource audioSource; // the whoosshh movement sound

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.mute = true;
        audioSource.playOnAwake = true;
        stopsMovementLayer = LayerMask.GetMask("StopsPlayerMovement");

        controls = new PlayerControl();

        controls.PlayerMoveInputs.PlayerMoveUp.performed += context => MoveUp();
        controls.PlayerMoveInputs.PlayerMoveDown.performed += context => MoveDown();
        controls.PlayerMoveInputs.PlayerMoveLeft.performed += context => MoveLeft();
        controls.PlayerMoveInputs.PlayerMoveRight.performed += context => MoveRight();
    }

    void Update()
    {
        GoalReached();
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
            MovementSound();
            transform.position += new UnityEngine.Vector3(0f, tileSize, 0f);
            Debug.Log("Up");
        }
        else
        {
            Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), stopsMovementLayer).GetComponent<WallSound>().PlaySound();
            Debug.Log("A wall was hit");
        }
    }

    void MoveDown()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), stopsMovementLayer))
        {
            MovementSound();
            transform.position -= new UnityEngine.Vector3(0f, tileSize, 0f);
            Debug.Log("Down");
        }
        else
        {
            Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), stopsMovementLayer).GetComponent<WallSound>().PlaySound();
            Debug.Log("A wall was hit");
        }
    }

    void MoveLeft()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), stopsMovementLayer))
        {
            MovementSound();
            transform.position -= new UnityEngine.Vector3(tileSize, 0f, 0f);
            Debug.Log("Left");
        }
        else
        {
            Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), stopsMovementLayer).GetComponent<WallSound>().PlaySound();
            Debug.Log("A wall was hit");
        }
    }

    void MoveRight()
    {
        // if theres no wall in the way, move
        if (!Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), stopsMovementLayer))
        {
            MovementSound();
            transform.position += new UnityEngine.Vector3(tileSize, 0f, 0f);
            Debug.Log("Right");
        }
        else
        {
            Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), stopsMovementLayer).GetComponent<WallSound>().PlaySound();
            Debug.Log("A wall was hit");
        }
    }

    void MovementSound()
    {
        audioSource.mute = false;
        Debug.Log("movement sound playing");
        StartCoroutine(DelayMute());
    }


    IEnumerator DelayMute()
    {
        yield return new WaitForSeconds(0.9f);
        Mute();
    }

    void Mute()
    {
        Debug.Log("movement sound muted");
        audioSource.mute = true;
    }

    void GoalReached()
    {
        if (transform.position.x == -8.25 && transform.position.y == 4.75)
        {
            SceneManager.LoadScene("End");
        }
    }
}
