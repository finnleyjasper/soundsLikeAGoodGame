using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.anyKey && !audioSource.isPlaying)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
