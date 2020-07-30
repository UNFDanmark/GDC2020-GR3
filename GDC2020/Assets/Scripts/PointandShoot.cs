using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointandShoot : MonoBehaviour
{
    
    public GameObject crosshair;
    public Transform player;
    public GameObject NoteBulletPrefab;
    public float timeOfLastNote = 0;
    public float coolDown = 1.5f;

    public float bulletSpeed = 60;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        timeOfLastNote = -coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(target.x, target.y);



        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (Input.GetButtonDown("Fire1") && Time.time - timeOfLastNote >= coolDown)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);

        }
    
    }

    void fireBullet(Vector2 direction, float rotationZ)
    {
        timeOfLastNote = Time.time;

        GameObject bnode = Instantiate(NoteBulletPrefab) as GameObject;
        bnode.transform.position = player.transform.position;
        bnode.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        bnode.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;   

    }
}