using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    private Animtor playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;}
    }

    void Update() {

    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gamover) { 
        playerRb.AddForce(Vector3.up * 10 jumpForce, ForceMode.Impulse);
        isOnGround = false; } }
        playerAnim.SetTrigger("Jump_trig"):}}
    }    

     private void OnCollisionEnter(Collision collision) {
      isOnGround = true; }