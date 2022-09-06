using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float speed; //Set speed value
public float rotSpeed; //Rotation speed
public float hInput; //horizontal input
public float vInput; //vertical input
public float jumpForce; //Jump height
public Rigidbody playerRB; //Reference Rigidbody component
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    hInput = Input.GetAxis("Horizontal");
    vInput = Input.GetAxis("Vertical");

    transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); //Rotate Left and Right
    transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); //Forward and backward movement

    if(Input.GetKeyDown(KeyCode.Space)) //Ceck for space button push
        playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //Makes player jump

    }



}
