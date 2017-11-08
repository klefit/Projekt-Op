﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    //Zmienne

    public Transform player;
    public float smooth = 0.3f;

    private Vector3 velocity = Vector3.zero;

    //Metody
    void Update()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.z = player.position.z;
        pos.y = 4.17f;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }

}
