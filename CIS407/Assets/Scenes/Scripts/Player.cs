using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        
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
}
