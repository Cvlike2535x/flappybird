using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float deadZone = -10;
    public float moveSpeed = 5;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
