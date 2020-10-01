using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //public GameObject obstacleObj;
    //public GameObject obstacleObj2;

    public GameObject[] obstacleOBJ;
    
    [SerializeField]
    public float timeToBoost = 5f;

    private float nextBoost;
    private float posR;
    private float nextSpawn;
    private float spawnRate;



    private void Start()
    {
        Time.timeScale = 2f;
        //spawnRate = 4f;
    }

    void Update()
    {

        if (Time.timeSinceLevelLoad > nextBoost && Obstacle.speed > -0.30f)
        {
            BoostTime();
            
        }
        Debug.Log(Obstacle.speed);
       // Debug.Log(Time.unscaledTime);
        if (Time.timeSinceLevelLoad > nextSpawn)
        {
            spawnRate = Random.Range(2, 5);
            //Debug.Log(tempo);
            int randomObj = Random.Range(0, obstacleOBJ.Length);
            posR = Random.Range(5f, 9f);
            nextSpawn = Time.timeSinceLevelLoad + spawnRate;
            Instantiate(obstacleOBJ[randomObj], new Vector2(posR, -3f), Quaternion.identity);
        }

        
    void BoostTime()
        {
            nextBoost = Time.timeSinceLevelLoad + timeToBoost;
            Obstacle.speed -= 0.01f;
            //Time.timeScale += 0.5f;
        }

    }
}
