using UnityEngine;
using UnityEngine.InputSystem;

public class RumbleInputManager : MonoBehaviour
{
    public static RumbleInputManager instance;

    [HideInInspector] public PlayerControl controls;
    private Gamepad pad;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        controls = new PlayerControl();
    }

    private void OnEnable()
    {
        controls.Rumble.Enable();
    }

    private void OnDisable()
    {
        controls.Rumble.Disable();
    }

    private void Update()
    {
        if (controls.Rumble.RumbleAction.WasPressedThisFrame())
        {
            RumbleStart(1f, 1f);
            Debug.Log("Warning Start");
        }

        if (controls.Rumble.RumbleAction.WasReleasedThisFrame())
        {
            RumbleStop();
            Debug.Log("Warning Stop");
        }
    }

    public void RumbleStart(float lowFrequency, float highFrequency)
    {
        //get reference to our Gamepad
        pad = Gamepad.current;

        //if we have a current Gamepad
        if (pad != null)
        {
            //start rumble
            pad.SetMotorSpeeds(lowFrequency,highFrequency);
        }
    }

    public void RumbleStop()
    {
        //get reference to our Gamepad
        pad = Gamepad.current;

        //if we have a current Gamepad
        if (pad != null)
        {
            //stop rumble
            pad.SetMotorSpeeds(0f, 0f);
        }
    }
}
