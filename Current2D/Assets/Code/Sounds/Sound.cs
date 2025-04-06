// Sound controls when it is played, and checks whether the player is near enough to activate it
// The player controls the Sound object's volume - though sound takes care of its own activation
// Essentially, all sounds will start playing when the player is near enough, but the player's
//  SoundControl script will determine the sound's volume and whether it is audible

using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    private LayerMask playerLayer;
    private LayerMask playerSoundLayer;

    [SerializeField] private float loopDelay; // how many seconds between each repeat of the sound
    private float timeLastPlayed = 0;

    public float defaultVolume = 1; // can change this in the editor if we want some sounds quieter than others

    private bool leaveFlag = false; // to check whether the player has left the sound space

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = 0;

        playerLayer = LayerMask.GetMask("Player");
        playerSoundLayer = LayerMask.GetMask("PlayerSoundDetection");
    }

    void Update()
    {
        // checks to see if the player's colliders are on top of this object
        //Collider2D player = Physics2D.OverlapPoint(new UnityEngine.Vector2(gameObject.transform.position.x, gameObject.transform.position.y), playerLayer);

        // checks to see if any of the player's sound detection colliders are on top of this object
        Collider2D soundcol = Physics2D.OverlapPoint(new UnityEngine.Vector2(gameObject.transform.position.x, gameObject.transform.position.y), playerSoundLayer);

        // if the player is near enough to activate, AND enough time has passed between loops, AND the sound isnt already playing
        if (Time.time >= timeLastPlayed + loopDelay && soundcol && !audioSource.isPlaying)
        {
            timeLastPlayed = Time.time;
            audioSource.Play();
            Debug.Log(gameObject.name + " has played a sound");
        }

        // if player is on the sound space
        // ^^ this shouldnt be a thing - only sound should be heard by useing the up/down/left/right
       /*  if (player)
        {
            audioSource.volume = defaultVolume/1.7f;
            if (Time.time >= timeLastPlayed + loopDelay && !audioSource.isPlaying)
            {
                timeLastPlayed = Time.time;
                audioSource.Play();

                Debug.Log(gameObject.name + " has played a sound");
            }
            leaveFlag = true;
            Debug.Log("Player is on \""+gameObject.name+"\" Space");
        }
        else if (!player)
        {
            if (leaveFlag == true)
            {
                leaveFlag = false;
                audioSource.volume = 0;
            }
        } */
    }
}
