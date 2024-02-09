using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement2 : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float xInput= Input.GetAxisRaw("Horizontal");
        if(xInput>0){
            rb.velocity=new Vector3(10f,0,0);
        }
        else if(xInput<0){
            rb.velocity = new Vector3(-10f,0,0);
        }

        float yInput= Input.GetAxisRaw("Vertical");
        if(yInput>0){
            rb.velocity=new Vector3(0,10f,0);
        }
        else if(yInput<0){
            rb.velocity = new Vector3(0,-10f,0);
        }
    }
}
