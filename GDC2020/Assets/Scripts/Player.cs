using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Fetches Rigidbody2D
    Rigidbody2D m_Rigidbody;

    // Sets the speed of the player
    public int moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.velocity = transform.forward * moveSpeed;
        }
    }

    private void FixedUpdate()
    {
        
    }
}
