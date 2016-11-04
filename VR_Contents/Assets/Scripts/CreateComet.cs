using UnityEngine;
using System.Collections;

public class CreateComet : MonoBehaviour {

    public GameObject playerObject;
    public GameObject cometPrefab;

    private GameObject comet;
    public GameObject comet_;

    private GameObject[] mkComet;
    public int cometCount = 0;
    public int spawnCount;
    public int mkInt; //生成個数
    public float spawnPoint;
    public float rangeX = 5.0f;
    public float rangeY = 5.0f;
    public float rangeZ = 1.0f;

    private CombineMesh combine;

    public bool startTF = false;

    public float playerZ;

	// Use this for initialization
	void Start () {
        comet_ = GameObject.Find("Comet_");
    }
	
	// Update is called once per frame
	void Update () {
        if(cometCount < mkInt)
        {
            for (int i = 0; i < 4; i++)
            {
                playerZ = playerObject.transform.position.z; //4個生成
                transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
                Debug.Log(transform.position);
                comet = (GameObject)Instantiate(cometPrefab, transform.position, transform.rotation);
                comet.transform.parent = comet_.transform;
            }

            //cometCount = 0;
            cometCount +=4;
            
        }
        else
        {
            startTF = true;
        }
	}
}
