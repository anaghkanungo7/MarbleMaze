using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 4;
    // Start is called before the first frame update

    Rigidbody _rigidbody;
    bool isGrounded = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Update runs as fast as you can
        // LateUpdate waits till all other update calls are done first
        // FixedUpdate runs  as per your time sequence
        

        // Implement Player Movement
        float zSpeed = Input.GetAxis("Horizontal") * speed; // modified as per camera movement
        float xSpeed = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3 (zSpeed, 0.0f, xSpeed);
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        relativeMovement += Vector3.right + Vector3.forward;

        _rigidbody.AddForce(relativeMovement);


        // _rigidbody.AddForce(new Vector3(xSpeed, 0, zSpeed));



        // Jumping functionality
        if (Input.GetButtonDown("Jump")) {
            if (isGrounded == true) {
                _rigidbody.AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
            }
            else {
                // print("Jump failed");
            }
            // print("Jump attempted!");
            isGrounded = false;
        }


    }
   
    void OnTriggerEnter(Collider theCollision) {
        if (theCollision.gameObject.tag == "floor") {
            isGrounded = true;
        }
        // else {
        //     isGrounded = false;
        // }

        // Additional code for boost and powerup platforms, etc. 
    }
};