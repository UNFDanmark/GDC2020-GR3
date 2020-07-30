using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicalNote : MonoBehaviour
{
    public float forwardSpeed = 4;

    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = transform.right * forwardSpeed;

        Destroy(gameObject, t:1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
