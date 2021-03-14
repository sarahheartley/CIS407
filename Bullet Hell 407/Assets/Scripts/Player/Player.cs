using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D playerRigidBody;
    private Vector3 change;
    public int maxHealth;
    public int currHealth;
    public Vector2 screenBoundary;

    public GameObject bullet;
    public Transform firePoint2;



    void Start()
    {

        currHealth = maxHealth;
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float changeX = Input.GetAxisRaw("Horizontal");
        float changeY = Input.GetAxisRaw("Vertical");

        //direction = new Vector2(changeX, changeY);

        playerRigidBody.velocity = new Vector2(changeX * speed, changeY * speed);


        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }


    void MoveCharacter()
    {
        playerRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
        {
            currHealth = currHealth - 1;
            if (currHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint2.position, firePoint2.rotation);
    }


}
