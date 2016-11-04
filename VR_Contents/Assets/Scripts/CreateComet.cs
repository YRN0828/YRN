using UnityEngine;
using System.Collections;

public class CreateComet : MonoBehaviour {

    public GameObject playerObject;
    public GameObject cometPrefab;
    private GameObject[] mkComet;
    public int cometCount = 0;
    public int spawnCount;
    public int mkInt; //生成個数
    public float spawnPoint;
    public float rangeX = 5.0f;
    public float rangeY = 5.0f;
    public float rangeZ = 1.0f;

    public bool startTF = false;

    public float playerZ;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //cometCount++;
        if(/*cometCount >= spawnCount*/ cometCount < mkInt)
        {
            playerZ = playerObject.transform.position.z; //1個目生成
            transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
            Debug.Log(transform.position);
            Instantiate(cometPrefab, transform.position, transform.rotation);

            playerZ = playerObject.transform.position.z; //2個目生成
            transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
            Debug.Log(transform.position);
            Instantiate(cometPrefab, transform.position, transform.rotation);

            playerZ = playerObject.transform.position.z; //3個目生成
            transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
            Debug.Log(transform.position);
            Instantiate(cometPrefab, transform.position, transform.rotation);

            playerZ = playerObject.transform.position.z; //4個目生成
            transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
            Debug.Log(transform.position);
            Instantiate(cometPrefab, transform.position, transform.rotation);


            //cometCount = 0;
            cometCount +=4;
        }
        else
        {
            startTF = true;
        }
	}
}
