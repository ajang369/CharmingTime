using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pjump : MonoBehaviour
{
    public float PlayerJumpPower = 2.5f;
    public bool isJump = false;
    public int jumpCount = 0;
    public bool isGround = false;

    protected Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (jumpCount < 1)
    //        {
    //            isJump = true;
    //            jumpCount++;
    //            isGround = false;
    //        }
    //    }

    //}
    //private void FixedUpdate()
    //{
    //    Jump();
    //}

    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    jumpCount = 0;
    //}

    //void Jump()
    //{
    //    if (!isJump)
    //        return;

    //    rb.velocity = Vector2.zero;

    //    Vector2 jumpVelocity = new Vector2(0f, PlayerJumpPower);
    //    rb.AddForce(jumpVelocity, ForceMode2D.Impulse);
    //    Debug.Log("jump");
    //    isJump = false;
    //}
    private void Update()
    {
        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                isJump = true;
                jumpCount++;
            }
        }
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if (!isJump)
            return;
        rb.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0f, PlayerJumpPower);
        rb.AddForce(jumpVelocity, ForceMode2D.Impulse);
        Debug.Log("jump");
        isJump = false;
        
    }

    void CheckGround()
    {
        float maxDistance = 0.82f;
        int layerMask = 1 << LayerMask.NameToLayer("Ground");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, maxDistance, layerMask);
        //bool isHit = Physics2D.Raycast(transform.position, Vector3.down, maxDistance);
        Debug.DrawRay(transform.position, Vector3.down * maxDistance, Color.red);

        if (hit.collider != null)
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.CompareTag("Ground"))
            {
                isGround = true;
                Debug.Log("ground");
                jumpCount = 0;
                return;
            }
        }
        /*
        if (Physics2D.Raycast(transform.position, Vector3.down, maxDistance))
        {
            Debug.Log(hit);
            if (hit.transform.CompareTag("Ground"))
            {
                isGround = true;
                Debug.Log("ground");
                return;
            }
        }*/

        //if (isHit)
        //{

        //    jumpCount = 0;
        //    isGround = true;
        //    isJump = false;
        //    Debug.Log("ground");
        //    return;
        //}
        isGround = false;
    }
}
