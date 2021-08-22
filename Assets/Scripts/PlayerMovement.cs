using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    // Reference to the Rigidbody component
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public bool moveLeft = false;
    public bool moveRight = false;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;
            moveLeft = false;
        }
        else if (Input.GetKey("a"))
        {
            moveLeft = true;
            moveRight = false;
        }
        else
        {
            moveLeft = false;
            moveRight = false;
        }
    }

    // FixedUpdate is perfered when using Unity's physics system
    // Update is called every frame
    void FixedUpdate()
    {
        // Time.deltaTime is the time in seconds between the last frame and the current frame
        // which helps apply constant force regardless of framerate
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
