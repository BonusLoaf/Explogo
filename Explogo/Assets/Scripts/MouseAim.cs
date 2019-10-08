﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothness = 2.0f;

    GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        var mousePoint = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mousePoint = Vector2.Scale(mousePoint, new Vector2(sensitivity * smoothness, sensitivity * smoothness));

        smoothV.x = Mathf.Lerp(smoothV.x, mousePoint.x, 1f / smoothness);
        smoothV.y = Mathf.Lerp(smoothV.y, mousePoint.y, 1f / smoothness);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);



        
    }
}