using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveDistance = 1f; // distance per button press
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            float moveX = 0;
            Debug.Log("Horizontal Input detected");

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveX = -1;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveX = 1;
            }

            targetPosition += new Vector3(moveX * moveDistance, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            float moveZ = 0;
            Debug.Log("Vertical Input detected");

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveZ = 1;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveZ = -1;
            }

            targetPosition += new Vector3(0, 0, moveZ * moveDistance);
        }

        transform.position = targetPosition;
    }
}
