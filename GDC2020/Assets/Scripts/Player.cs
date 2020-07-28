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
        //Move();
        if (Input.GetKey(KeyCode.W)){
            transform.position += Vector3.right * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= Vector3.right * Time.deltaTime;
        }
    }

    public void Move() {
        // Blue vector forward (blue) is the one which moves the player downward, so right vector(red) is used as forward instead.
        //Vector3 forwardMovement  = transform.right * Input.GetAxis("Vertical");
    }

}
