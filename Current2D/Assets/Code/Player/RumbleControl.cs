using UnityEngine;
using UnityEngine.Audio;

public class RumbleControl : MonoBehaviour
{
    public GameObject RumbleManager; // Reference to the Rumble manager game object
    RumbleInputManager rumbles; // Reference to the RumbleInputManager class within the gameobject

    PlayerControl controls; // the action map used to access controller input
    private LayerMask soundsLayer; // all sounds should be on this layer
    private float tileSize = 0.5f; // the size of the tiles needed to know how far to check in each direction

    void Awake()
    {
        soundsLayer = LayerMask.GetMask("Sounds");
        controls = new PlayerControl();

        try
        {
            rumbles = RumbleManager.GetComponent<RumbleInputManager>();
        }
        catch
        {
            Debug.Log("Fail to load Rumble Input Manager");
        }

        controls.PlayerSoundSearch.CheckLeft.started += context => OpenLeft();
        controls.PlayerSoundSearch.CheckLeft.canceled += context => CloseLeft();

        controls.PlayerSoundSearch.CheckRight.started += context => OpenRight();
        controls.PlayerSoundSearch.CheckRight.canceled += context => CloseRight();

        controls.PlayerSoundSearch.CheckFront.started += context => OpenFront();
        controls.PlayerSoundSearch.CheckFront.canceled += context => CloseFront();

        controls.PlayerSoundSearch.CheckBehind.started += context => OpenBehind();
        controls.PlayerSoundSearch.CheckBehind.canceled += context => CloseBehind();

    }

    void OnEnable()
    {
        controls.PlayerSoundSearch.Enable();
    }

    void OnDisable()
    {
        controls.PlayerSoundSearch.Disable();
    }

    void OpenLeft()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), soundsLayer);

        if (soundCol&&rumbles!=null)
        {
            rumbles.RumblePulses(0.05f, 0.05f,0.3f);
        }
    }

    void CloseLeft()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), soundsLayer);

        if (soundCol&&rumbles != null)
        {
            rumbles.RumbleStop();
        }
    }

    void OpenRight()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumblePulses(0.05f, 0.05f, 0.3f);
        }
    }

    void CloseRight()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumbleStop();
        }
    }

    void OpenFront()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumblePulses(0.05f, 0.05f, 0.3f);
        }
    }

    void CloseFront()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumbleStop();
        }
    }

    void OpenBehind()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumblePulses(0.05f, 0.05f, 0.3f);
        }
    }

    void CloseBehind()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), soundsLayer);

        if (soundCol && rumbles != null)
        {
            rumbles.RumbleStop();
        }
    }
}

