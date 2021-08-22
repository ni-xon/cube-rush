using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Define a player variable which references a Transform component (can be any Transform component)
    public Transform player;
    // Vector3 data type stores 3 floats as a tuple
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // transform refers to the transform component of the object the script is being applied to
        transform.position = player.position + offset;
    }
}
