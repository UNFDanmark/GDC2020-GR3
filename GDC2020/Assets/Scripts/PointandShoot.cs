using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointandShoot : MonoBehaviour
{

    public GameObject crosshair;
    public Transform player;
    public GameObject NoteBulletPrefab;
    public float timeOfLastNote = 0;
    public float coolDown = 1.5f;
    public float knockBack = 2;
    public Rigidbody myRigidbody;
    public Camera playerCam;
    public PointCount pointCount;

    public float bulletSpeed = 60;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Cursor.visible = false;
        timeOfLastNote = -coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        target = playerCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
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

            myRigidbody.AddForce(-transform.forward);

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

    public void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            PickUp(col.gameObject);
        }
    }

    public void PickUp(GameObject Enemy)
    {
        Enemy.SetActive(false);
        Destroy(Enemy);
        pointCount.GetPoints(1);

    }

}