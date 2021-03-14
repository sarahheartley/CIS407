using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HW : MonoBehaviour
{
    public GameObject bullet;
    public int health = 1;
    public Transform firePoint;
    public Rigidbody2D hwRigidBody;
    int speed = 1;
    float randInt;

    // Start is called before the first frame update
    void Start()
    {
        randInt = Random.Range(3, 4);
        InvokeRepeating("shootPlayer", 0, randInt);
        Destroy(gameObject, 20.0f);

    }

    // Update is called once per frame
    void Update()
    {
        hwRigidBody = GetComponent<Rigidbody2D>();
        hwRigidBody.velocity = -transform.up * speed;

    }
    public void hit()
    {
        //print("object was hit so bad ");
        health = health - 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    void shootPlayer()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerBullet")
        {
            hit();
        }

        else if (collision.tag == "bottomWall")
        {

            Destroy(gameObject);
        }
    }
}
