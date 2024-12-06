using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    public float forwardInput;
    private Rigidbody playerRb;
    public float gravityModifier;
    public float jumpForce;
    private Animator playerAnim;
    public bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (forwardInput != 0)
        {   
            Debug.Log ("here");
            playerAnim.SetBool("Static_b", true);
            playerAnim.SetFloat("Speed_f", 1f);
        }
        else if (forwardInput == 0)
        { 
            playerAnim.SetFloat("Speed_f", 0f);
        }
  // Move player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
       {
            isOnGround = true;
        }
    }
}