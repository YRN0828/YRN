using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(GameObject cameraObject, float speed, int moveType, float rotaF)
    {
        this.transform.Translate(0, 0, speed);

        if (moveType == 0)
        {
            this.transform.Rotate(-Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
        else if (moveType == 1)
        {
            this.transform.Rotate(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
        else if(moveType == 2)
        {
            this.transform.Rotate(-Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
        else
        {
            this.transform.Rotate(Input.GetAxis("Vertical"), -Input.GetAxis("Horizontal"), 0);
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
    }
}
