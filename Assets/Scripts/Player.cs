using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] LayerMask ground;
    [SerializeField] float runSpeed;
    [SerializeField] float jumpSpeed;
    Rigidbody2D myRigidBody;
    BoxCollider2D boxCollider;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void FixedUpdate()
    {
        Jump();
        Move(); 
    }
    private void Move()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * runSpeed;
        }
    }
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && boxCollider.IsTouchingLayers(ground))
        {
                myRigidBody.velocity = Vector2.up * jumpSpeed;
        }
    }
}
