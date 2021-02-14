using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;
    public int startHp;
    int hp;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        hp = startHp;
        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
        
    }

    void MoveCharacter()
    {
        myRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            hp -= 1;
            print(hp)
        }
    }
}
