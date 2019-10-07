using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public int obstacleMaximum;
    public int obstacleNumber;
    // Start is called before the first frame update
    void Start()
    {
        while(obstacleNumber < obstacleMaximum)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
           

            Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(0, 0, Random.Range(25, 50
                )), obstaclePrefabs[obstacleIndex].transform.rotation);

            obstacleNumber++;
        }
        
    }
        // Update is called once per frame
        void Update()
    {
        while (obstacleNumber < obstacleMaximum)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);


            Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(0, 0, Random.Range(25, 50
                )), obstaclePrefabs[obstacleIndex].transform.rotation);

            obstacleNumber++;
        }
    }
}
