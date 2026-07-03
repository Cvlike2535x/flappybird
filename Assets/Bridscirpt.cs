using UnityEngine;
using UnityEngine.InputSystem;

public class Bridscirpt : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float jumpForce = 10f;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

  
  void Update()
{
    if (Keyboard.current.spaceKey.wasPressedThisFrame)
    {
        myRigibody.linearVelocity = new Vector2(0, jumpForce * 2);
    }
}}
