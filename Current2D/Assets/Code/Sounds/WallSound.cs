using UnityEngine;
using System.Collections;

public class WallSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip bonk;
    [SerializeField] private AudioClip hullDamage;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        if (ShouldPlayHullDamage())
        {
            audioSource.clip = bonk;
            audioSource.Play();
            StartCoroutine(DelayHullDamage());
        }
        else
        {
            audioSource.clip = bonk;
            audioSource.Play();
        }
    }

    private bool ShouldPlayHullDamage() // will either be just the bonk or bonk and hull damaged
    {
        int outcome = Random.Range(0, 10); // random number 0-9

        if (outcome == 9) // 1/10 change hull damage will occur
        {
            return true;
        }

        return false;
    }

    IEnumerator DelayHullDamage()
    {
        yield return new WaitForSeconds(1.5f);
        PlayeHullDamage();
    }

    void PlayeHullDamage()
    {
            audioSource.clip = hullDamage;
            audioSource.Play();
    }
}
