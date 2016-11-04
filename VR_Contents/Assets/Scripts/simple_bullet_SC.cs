using UnityEngine;
using System.Collections;

public class simple_bullet_SC : MonoBehaviour {

    public float speed=1.0f;
    public int lifetime=300;
    int Timecount=0;
    float z;

	// Use this for initialization
	void Start () {
        z = transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed);
        if (transform.position.z - z >= 300 || transform.position.z - z <= -300)
        {
            Destroy(this.gameObject);
        }
    }
}
