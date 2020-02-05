using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float xSpeed = -2f;
    public float ySpeed = 0f;

    void FixedUpdate()
    {
        //Pohyb po xovej osy o 1 kazdy frame
        transform.position = transform.position + new Vector3(xSpeed, ySpeed, 0f);
    }
}
