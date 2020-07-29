using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    public float enemySpeed = 4;
    private Vector2 movement;
    public Transform player;
    public Rigidbody enemyRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //enemyRigidbody.rotation = Quaternion.Euler(0f, 0f, angle);
        transform.up = direction;
        direction.Normalize();
        movement = direction;

        moveCharacter(direction);
    }

    void moveCharacter(Vector2 direction)
    {
        enemyRigidbody.velocity = direction * enemySpeed;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene("GameOver");
    }
}
