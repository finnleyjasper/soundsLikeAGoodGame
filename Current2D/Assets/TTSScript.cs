using UnityEngine;
using System.Collections;

public class TTSScript : MonoBehaviour
{
    private AudioSource audioSource;
    public bool played = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(DelayTTS());
    }

    IEnumerator DelayTTS()
    {
        yield return new WaitForSeconds(2f);
        PlayTTS();
    }

    void PlayTTS()
    {
        audioSource.Play();
        played = true;
    }

}
