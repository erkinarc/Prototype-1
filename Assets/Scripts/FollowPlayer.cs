using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player; // Reference to the player object
    private Vector3 offset = new Vector3(0, 6, -10); // Offset from the player position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
