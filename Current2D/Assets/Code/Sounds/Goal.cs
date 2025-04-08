using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private AudioSource audioSource;

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    [SerializeField] LayerMask playerLayer;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        playerLayer = LayerMask.GetMask("Player");
    }


    // for some reason i just *cannot* get this to work :(
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("collided with " + other.gameObject.name);
/*             Debug.Log("yippeee");
            // stop player movement
            other.gameObject.GetComponent<PlayerMovement>().controls.Disable();
            // play the audio
            audioSource.Play();
            // then move the player to the end scene when the audio is done */
            if (!audioSource.isPlaying)
            {
                SceneManager.LoadScene("End");
            }
        }
        else {
            Debug.Log("game object " + other.gameObject.name + "on layer: " + other.gameObject.layer + "has collided");
        }
    }
}
