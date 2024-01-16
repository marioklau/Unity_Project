using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish2 : MonoBehaviour
{
    public GameObject fish2;
    public float timeBetweenSpawn;
    public float spawnTime;

    // Start is called before the first frame update
    void Update()
    {
        if (Time.time > spawnTime)
        {   
            SpawnIkanJalan();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    // Update is called once per frame
    void SpawnIkanJalan()
    {
        float randomY = Random.Range(-2,4);

        Instantiate(fish2, new Vector3(10, randomY, 0), transform.rotation);

    }
}
