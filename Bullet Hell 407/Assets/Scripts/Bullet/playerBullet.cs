using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    public Rigidbody2D bulletRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody2D>();
        bulletRigidBody.velocity = transform.up * speed;
        Destroy(gameObject, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
