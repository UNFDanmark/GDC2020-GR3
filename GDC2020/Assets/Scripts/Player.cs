using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3.5f;

    public Rigidbody myRigidbody;
    public GameObject musicalNotePrefab;

    // Cooldown timer.
    //public float timeOfLastNote = 0;
    //public float coolDown = 1;

    // Start is called before the first frame update
    void Start()
    {
        //timeOfLastNote = -coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        // Makes it possible to shoot
        //if (Input.GetMouseButtonDown(0) && Time.time - timeOfLastNote > coolDown)
        //{
        //    shootMusicalNote();
        //}
    }

    void FixedUpdate()
    {
        Move();

    }

    public void Move()
    {
        // Blue vector forward (blue) is the one which moves the player downward, so right vector(red) is used as forward instead.


        Vector2 upwardMovement = Vector3.up * Input.GetAxis("Vertical");
        Vector2 sideMovement = Vector3.right * Input.GetAxis("Horizontal");
        Vector2 allMovement = upwardMovement + sideMovement;

        allMovement.Normalize();


        myRigidbody.velocity = allMovement * moveSpeed;
    }



    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.CompareTag("Enemy"));
        //{
        //    KillPlayer();
        //}
            
    }

    // Method for shooting musical notes.
    //public void shootMusicalNote()
    //{
    //    GameObject newMusicalNote = Instantiate(musicalNotePrefab);

    //    newMusicalNote.transform.position = transform.position;
    //    newMusicalNote.transform.rotation = transform.rotation;

    //}

}
