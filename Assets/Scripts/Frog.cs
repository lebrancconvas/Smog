using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public float moveSpeed;
    private float xInput, yInput; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);
    }
}
