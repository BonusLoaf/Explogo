﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPull : MonoBehaviour
{


    public Transform camTrans;


    private float shiftVal = 5000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Invoke("pushIn", 0.2f);
        
    }

    private void OnTriggerExit(Collider other)
    {

        Invoke("pushOut", 1f);

    }

    void pushIn()
    {
        transform.Translate(0, 0, 4);
    }


    void pushOut()
    {
        transform.Translate(0, 0, -4);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}