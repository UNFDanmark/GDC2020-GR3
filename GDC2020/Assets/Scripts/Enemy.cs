using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    public float enemySpeed = 4;

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
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
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
