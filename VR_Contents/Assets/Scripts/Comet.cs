using UnityEngine;
using System.Collections;

public class Comet : MonoBehaviour {

    public GameObject playerObject;
    public float destroyTime;

	// Use this for initialization
	void Start () {
        //playerObject = GameObject.Find("Player");
        //Destroy(gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
	    /*if(Vector3.Distance(playerObject.transform.position,this.transform.position) >= 50.0f)
        {
            Destroy(this.gameObject);
        }*/
	}
}
