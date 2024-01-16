using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject food;
    public float timeBetweenSpawn;
    public float spawnTime;

    // Start is called before the first frame update
    void Update()
    {
        if (Time.time > spawnTime)
        {   
            SpawnMakan();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    // Update is called once per frame
    void SpawnMakan()
    {
        float randomX = Random.Range(-5,11);

        Instantiate(food, new Vector3(randomX, 3, 0), transform.rotation);

    }

    private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.CompareTag("Makan1")) {
            Destroy(other.gameObject);
       }
    }
}
