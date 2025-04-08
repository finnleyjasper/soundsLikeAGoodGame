using TMPro;
//using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText; // used for debugging atm - player wont see

    public float timeLimit = 60f;
    private float remainingTime;

    void Start()
    {
        remainingTime = timeLimit;
    }


    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
        }

        if (remainingTime == 0)
        {
            SceneManager.LoadScene("End");
        }

        timerText.text = remainingTime.ToString();
    }
}
