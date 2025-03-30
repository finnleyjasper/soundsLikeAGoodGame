// yeah this is an inefficient script but who cares

using System;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    PlayerControl controls; // the action map used to access controller input
    private LayerMask soundsLayer; // all sounds should be on this layer
    private int tileSize = 1; // the size of the tiles needed to know how far to check in each direction

    void Awake()
    {
        soundsLayer = LayerMask.GetMask("Sounds");
        controls = new PlayerControl();

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

        if (soundCol)
        {
            Debug.Log("Found a sound on the left called " + soundCol.gameObject.name);
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();

            try
            {
                sound.GetComponent<AudioSource>().volume = sound.gameObject.GetComponent<Sound>().defaultVolume; // turn the volume up on this sound
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on sound object " + sound.gameObject.name);
            }
        }
    }

    void CloseLeft()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x - tileSize, transform.position.y), soundsLayer);

        if (soundCol)
        {
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();
            try
            {
                sound.GetComponent<AudioSource>().volume = 0; // turn the off when trigger is released
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on " + sound.gameObject.name);
            }
        }
    }

    void OpenRight()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), soundsLayer);

        if (soundCol)
        {
            Debug.Log("Found a sound on the right called " + soundCol.gameObject.name);
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();

            try
            {
                sound.GetComponent<AudioSource>().volume = sound.gameObject.GetComponent<Sound>().defaultVolume; // turn the volume up on this sound
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on sound object " + sound.gameObject.name);
            }
        }
    }

    void CloseRight()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x + tileSize, transform.position.y), soundsLayer);

        if (soundCol)
        {
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();
            try
            {
                sound.GetComponent<AudioSource>().volume = 0; // turn the off when trigger is released
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on " + sound.gameObject.name);
            }
        }
    }

    void OpenFront()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), soundsLayer);

        if (soundCol)
        {
            Debug.Log("Found a sound ahead called " + soundCol.gameObject.name);

            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();

            try
            {
                sound.GetComponent<AudioSource>().volume = sound.gameObject.GetComponent<Sound>().defaultVolume; // turn the volume up on this sound
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on sound object " + sound.gameObject.name);
            }
        }
    }

    void CloseFront()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y + tileSize), soundsLayer);

        if (soundCol)
        {
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();
            try
            {
                sound.GetComponent<AudioSource>().volume = 0; // turn the off when trigger is released
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on " + sound.gameObject.name);
            }
        }
    }

  void OpenBehind()
    {

        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), soundsLayer);

        if (soundCol)
        {
            Debug.Log("Found a sound behind called " + soundCol.gameObject.name);
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();

            try
            {
                sound.GetComponent<AudioSource>().volume = sound.gameObject.GetComponent<Sound>().defaultVolume; // turn the volume up on this sound
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on sound object " + sound.gameObject.name);
            }
        }
    }

    void CloseBehind()
    {
        Collider2D soundCol = Physics2D.OverlapPoint(new UnityEngine.Vector2(transform.position.x, transform.position.y - tileSize), soundsLayer);

        if (soundCol)
        {
            AudioSource sound = soundCol.gameObject.GetComponent<AudioSource>();
            try
            {
                sound.GetComponent<AudioSource>().volume = 0; // turn the off when trigger is released
            }
            catch
            {
                Debug.Log("ERROR: No AudioSource found on " + sound.gameObject.name);
            }
        }
    }


}
