using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private bool start = false;
    public float speed;
    public float x;
    public float y;
    public float z;
    public float rotaF;

    public GameObject cameraObject;

	// Use this for initialization
	void Start ()
    {
        cameraObject = GameObject.Find("Main Camera");

        transform.localPosition = Vector3.zero;

        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        if (start != true)
        {
            start = GameObject.Find("CreateComet").GetComponent<CreateComet>().startTF;
        }
        else
        {
            this.transform.Translate(0, 0, speed);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Rotate(0, /*-rotaF */ 0,/* 0*/-rotaF);
                //this.transform.Rotate(0, -rotaF, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Rotate(0, /*rotaF*/0,/* 0*/rotaF);
                //this.transform.Rotate(0, rotaF, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Rotate(rotaF, 0, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Rotate(-rotaF, 0, 0);
            }

            this.transform.Rotate(Input.GetAxis("Vertical"),/* Input.GetAxis("Horizontal")*/0, /*0*/ - Input.GetAxis("Horizontal"));
            //this.transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);

            cameraObject.transform.Rotate(cameraObject.transform.rotation.x + Input.GetAxis("Vertical"), cameraObject.transform.rotation.y/* + Input.GetAxis("Horizontal")*/, cameraObject.transform.rotation.z + Input.GetAxis("Horizontal"));
            //cameraObject.transform.Rotate(cameraObject.transform.rotation.x + Input.GetAxis("Vertical"), cameraObject.transform.rotation.y + Input.GetAxis("Horizontal"), cameraObject.transform.rotation.z);

        }
	}
}
