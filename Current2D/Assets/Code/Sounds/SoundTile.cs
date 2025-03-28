using UnityEngine;

public class SoundTile : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void Activate()
    {
        audioSource.volume = 1;
    }

     public void Deactivate()
    {
        audioSource.volume = 0;
    }
}
