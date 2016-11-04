using UnityEngine;
using System.Collections;

public class simple_bullet_SC : MonoBehaviour {

    public float speed=1.0f;
    public int lifetime=300;
    int Timecount=0;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Timecount >= lifetime)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(0, 0, speed);
        Timecount++;
	}
}
