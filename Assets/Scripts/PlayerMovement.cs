using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public float movementSpeed;

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void moveCharacter(Vector3 movement)
    {
        playerRb.AddRelativeForce(movement * movementSpeed);
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
}
