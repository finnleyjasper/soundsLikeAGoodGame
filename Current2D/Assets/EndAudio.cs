using UnityEngine;
using System.Collections;

public class EndAudio : MonoBehaviour
{

    public AudioSource thisAudioSource;
    public GameObject TTSAudioSource;
    private bool played = false;

    void Awake()
    {
        thisAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (TTSAudioSource.GetComponent<TTSScript>().played && !TTSAudioSource.GetComponent<AudioSource>().isPlaying && !played)
        {
            played = true;
            StartCoroutine(DelayCronch());
        }

        if (played)
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("Game quit");
                Application.Quit();
            }
        }
    }

    IEnumerator DelayCronch()
    {
        yield return new WaitForSeconds(3f);
        PlayCronch();
    }

    void PlayCronch()
    {
            thisAudioSource.Play();
    }
}
