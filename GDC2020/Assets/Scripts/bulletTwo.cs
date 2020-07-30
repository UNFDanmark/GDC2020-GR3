using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTwo : MonoBehaviour
{

    public float forwardSpeed = 3;
    public Rigidbody myRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = transform.forward * forwardSpeed;

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
