using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointandShoot : MonoBehaviour
{
    
    public GameObject crosshair;
    public Transform player;
    public GameObject NoteBulletPrefab;

    public float bulletSpeed = 60;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(target.x, target.y);



    //    Vector3 difference = target - player.transform.position;
    //    //float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    //    //player.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        float distance = difference.magnitude;
    //        Vector2 direction = difference / distance;
    //        direction.Normalize();
    //        fireBullet(direction, target);

    //    }
      
    //}

    //void fireBullet(Vector2 dirction, float target)
    //{
    //    GameObject bulletz = Instantiate(NoteBulletPrefab) as GameObject;
    //    bulletz.transform.position = player.transform.position;

    }
}