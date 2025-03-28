using UnityEngine;

public class AudioOcclusion : MonoBehaviour
{
    [SerializeField] private GameObject listener;  // the player object

    // distance-based occlusion will be done later, just working on walls for now
    [SerializeField] private float maxOcclusionDistance = 10f; // maximum distance for occlusion to affect sound
    // [SerializeField] private float occlusionAmount = 0.5f; // how much to reduce volume when occluded

    private AudioSource audioSource; // The audio source component

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        listener = GameObject.Find("Player"); // HARD CODED - Player must be called "Player"
        audioSource.volume = 0;
    }

    void Start()
    {

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on " + gameObject.name);
            enabled = false; // disable this script
            return;
        }

        if (listener == null)
        {
            Debug.LogError("A sounds could not find the Player's audio listener");
            enabled = false; // disable this script
            return;
        }
    }

    void FixedUpdate()
    {
        if (listener == null)
        {
            Debug.Log("The sound could not find a listener");
            return; // exit if either listener or soundSource is null
        }

        // adjust volume if theres a wall
        if (ShouldBeSilent())
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 1f; // restore full volume
        }

        // reduce based on distance
        // audioSource.volume = Mathf.Lerp(1f, 0f, occlusionAmount); // reduce volume
    }

    bool ShouldBeSilent()
    {
        // raycast from listener to sound source
        RaycastHit hit;
        if (Physics.Raycast(listener.transform.position, (listener.transform.position - gameObject.transform.position), out hit, maxOcclusionDistance))
        {
            // if theres a wall, turn off sound
            if (hit.collider.gameObject.tag == "Wall")
            {
                Debug.Log("There is a wall blocking " + gameObject.name);
                return true; // sound is occluded
            }

            // if the player is super far away, turn off sound
            if (Vector3.Distance(gameObject.transform.position, listener.transform.position) < maxOcclusionDistance)
            {
                Debug.Log(gameObject.name + " is too far away");
                return true; // sound is occluded
            }
        }
        return false; // sound is not occluded
    }
}
