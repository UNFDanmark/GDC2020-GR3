using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
        Strafe();

       // if (Input.GetKey(KeyCode.A)){
         //   transform.position -= Vector3.right * Time.deltaTime;
        // }
       // else if (Input.GetKey(KeyCode.D))
        //{
      //      transform.position += Vector3.right * Time.deltaTime;
       // }
    }

    public void Move()
    {
        // Blue vector forward (blue) is the one which moves the player downward, so right vector(red) is used as forward instead.
        //Vector3 forwardMovement  = transform.right * Input.GetAxis("Vertical");

      

        Vector2 upwardMovement = transform.up * Input.GetAxis("Vertical") * moveSpeed;

        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0) + -upwardMovement;
    }


    public void Strafe()
    {

        Vector2 sideMovement = transform.right * Input.GetAxis("Horizontal") * moveSpeed;

        myRigidbody.velocity = new Vector2(0, myRigidbody.velocity.y) + sideMovement;

    }
}
