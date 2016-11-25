﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private bool start = false;
    public float speed;
    public float rotaF;

    public int moveType = 0;

    public GameObject simplebullet;
    GameObject hassyakou;//バルカン発射口？

    private int stayFire;
    public int stayTime = 20;

    public GameObject cameraObject;

    private PlayerMove playerMove;

    private int i = 0;

	// Use this for initialization
	void Start ()
    {
        cameraObject = GameObject.Find("Main Camera");
        hassyakou = transform.FindChild("hassyakou").gameObject;

        playerMove = GetComponent<PlayerMove>();

        transform.localPosition = Vector3.zero;

        stayFire = stayTime;
    }
	
	// Update is called once per frame
	void Update () {
        if (start != true)
        {
            start = GameObject.Find("CreateComet").GetComponent<CreateComet>().startTF;
        }
        else
        {
            playerMove.Move(cameraObject, speed, moveType, rotaF);

            if (stayFire < stayTime)
            {
                stayFire++;
            }

            simplebullet_fire();
        }
	}

    void simplebullet_fire() //バルカン？
    {
        if (Input.GetButton(buttonName:"Fire1") && stayFire == stayTime)
        {
            Instantiate(simplebullet, hassyakou.transform.position, hassyakou.transform.rotation);
            stayFire = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "SComet(Clone)")
        {
            start = false;
            GameObject.Find("CreateComet").GetComponent<CreateComet>().startTF = false;
        }
    }
}
