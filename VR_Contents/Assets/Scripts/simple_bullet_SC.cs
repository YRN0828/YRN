﻿using UnityEngine;
using System.Collections;

public class simple_bullet_SC : MonoBehaviour {

    public float speed=1.0f;
    public int lifetime = 300;
    public int Timecount=0;
    float z;

	// Use this for initialization
	void Start () {
        z = transform.position.z;
        lifetime = Mathf.FloorToInt(Camera.main.far) + 10;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed);
        if (transform.position.z - z >= speed * lifetime)
        {
            Destroy(this.gameObject);
        }
    }
}
