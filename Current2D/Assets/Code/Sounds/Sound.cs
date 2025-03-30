// Sound controls when it is played, and checks whether the player is near enough to activate it
// The player controls the Sound object's volume - though sound takes care of its own activation
// Essentially, all sounds will start playing when the player is near enough, but the player's
//  SoundControl script will determine the sound's volume and whether it is audible

using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    private LayerMask playerLayer;

    [SerializeField] private float loopDelay; // how many seconds between each repeat of the sound
    private float timeLastPlayed = 0;

    public float defaultVolume = 1; // can change this in the editor if we want some sounds quieter than others


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = 0;

        playerLayer = LayerMask.GetMask("PlayerSoundDetection");

    }

    void Update()
    {
        // checks to see if any of the player's sound detection colliders are on top of this object
        Collider2D player = Physics2D.OverlapPoint(new UnityEngine.Vector2(gameObject.transform.position.x, gameObject.transform.position.y), playerLayer);

        // if the player is near enough to activate, AND enough time has passed between loops, AND the sound isnt already playing
        if (Time.time >= timeLastPlayed + loopDelay && player && !audioSource.isPlaying)
        {
            timeLastPlayed = Time.time;
            audioSource.Play();

            Debug.Log(gameObject.name + " has played a sound");
        }
    }
}
