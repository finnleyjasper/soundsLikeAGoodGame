using System.Threading;
using UnityEngine;
using UnityEngine.Audio;

public class DelayLoopedSound : MonoBehaviour
{
    [SerializeField] public float Delay;

    public AudioSource[] audios;

    private float timeLastPlayed = 0;

    void Start()
    {
        timeLastPlayed = Time.time;

        for (int count = 0; count < audios.Length; count++)
        {
            audios[count].Stop();
        }
    }

    void Update()
    {
        float upperbound = audios.Length - 0.01f;

        int count = (int)Mathf.Floor(Random.Range(0f, upperbound));

        if (Time.time >= timeLastPlayed + Delay && !audios[count].isPlaying)
        {
            Debug.Log(count);
            timeLastPlayed = Time.time;
            audios[count].Play();
            Debug.Log(gameObject.name + " has played a sound");
        }
        
    }
}
