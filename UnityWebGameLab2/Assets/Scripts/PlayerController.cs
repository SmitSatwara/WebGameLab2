using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce=50;
    public float jumpForce = 100;
    public Rigidbody rd;
    public bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround) { 
       
            if (Input.GetAxisRaw("Horizontal")>0)
            {
                rd.AddForce(Vector3.right * moveForce);
            Debug.Log("Right");
            }
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                rd.AddForce(Vector3.left * moveForce);
            }
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                rd.AddForce(Vector3.forward * moveForce);
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                rd.AddForce(Vector3.back * moveForce);
            }
            if (Input.GetAxisRaw("Jump")>0)
            {
                rd.AddForce(Vector3.up * jumpForce);
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
