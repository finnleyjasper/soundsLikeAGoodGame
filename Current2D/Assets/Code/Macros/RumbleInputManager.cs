using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class RumbleInputManager : MonoBehaviour
{
    public static RumbleInputManager instance;

    [HideInInspector] public PlayerControl controls;
    private Gamepad pad;

    private Coroutine stopRumbleAfterTimeCoroutine;

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

    public void RumblePulses(float lowFrequency, float highFrequency, float duration)
    {
        //get reference to our Gamepad
        pad = Gamepad.current;

        //if we have a current Gamepad
        if (pad != null)
        {
            pad.SetMotorSpeeds(lowFrequency, highFrequency);
            stopRumbleAfterTimeCoroutine = StartCoroutine(TimeStopRumble(duration, pad,lowFrequency,highFrequency));
        }
    }

    private IEnumerator TimeStopRumble (float duration, Gamepad pad, float lowFrequency, float highFrequency)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        pad.SetMotorSpeeds(0f, 0f);
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        pad.SetMotorSpeeds(lowFrequency, highFrequency);
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        pad.SetMotorSpeeds(0f, 0f);
    }
}
