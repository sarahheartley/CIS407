using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HWBullet : MonoBehaviour
{
    //public Vector2 velocity;
    public float speed;
    public Rigidbody2D bullet2RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        bullet2RigidBody = GetComponent<Rigidbody2D>();
        bullet2RigidBody.velocity = -transform.up * speed;
        Destroy(gameObject, 1.0f);


    }



    // Update is called once per frame
    void Update()
    {

        //transform.Translate(velocity * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bottomWall")
        {
            print("nice");
            Destroy(gameObject);
        }
    }


}
