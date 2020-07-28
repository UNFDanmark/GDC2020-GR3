using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;

    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move() {
        // Blue vector forward (blue) is the one which moves the player downward, so right vector(red) is used as forward instead.
        Vector3 forwardMovement  = transform.right * Input.GetAxis("Vertical");
    }

}
