using UnityEngine;

public class Goal : MonoBehaviour
{
    private Collider2D collider2D;
    private AudioSource audioSource;

    void Awake()
    {
        collider2D = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // stop player movement
            collision.gameObject.GetComponent<PlayerMovement>().controls.Disable();
            audioSource.Play();
        }
    }
}
