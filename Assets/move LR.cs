using UnityEngine;

public class MoveLR : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed at which the cube moves
    private float moveDirection = 1f;  // Direction of movement (1 for right, -1 for left)

    // Update is called once per frame
    void Update()
    {
        // Move the cube along the x-axis based on moveDirection
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, 0f, 0f);

        // If the cube reaches a certain boundary, reverse its direction
        if (transform.position.x >= 5f)  // Right boundary
        {
            moveDirection = -1f;  // Move left
        }
        else if (transform.position.x <= -5f)  // Left boundary
        {
            moveDirection = 1f;  // Move right
        }
    }
}
