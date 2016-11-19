using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowFPS : MonoBehaviour {

    private int timeCount;

    public float updateInterval = 0.5f;
    private float accum = 0;
    private int frames = 0;
    private float timeLeft;

	// Use this for initialization
	void Start () {
        //timeCount = 0;

        timeLeft = updateInterval;
	}

    // Update is called once per frame
    void Update()
    {/*
        timeCount++;
        if (timeCount >= 20)
        {
            this.GetComponent<Text>().text = (1 / Time.deltaTime).ToString() + "fps";
            timeCount = 0;
        }*/

        timeLeft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeLeft <= 0.0)
        {
            float fps = accum / frames;
            this.GetComponent<Text>().text = fps.ToString() + "fps";

            timeLeft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }
}
