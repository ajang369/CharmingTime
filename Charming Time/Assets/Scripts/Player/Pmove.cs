using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    public float PlayerMovePower = 2.0f;

    Rigidbody2D rigid;
    Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            moveVelocity = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)==true)
        {
            moveVelocity = Vector3.left;
        }
        transform.position += moveVelocity * PlayerMovePower * Time.deltaTime;
    }
}
