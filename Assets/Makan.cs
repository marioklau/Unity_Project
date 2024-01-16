using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makan : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        
        if (other.gameObject.CompareTag("Makan1")){
            Destroy(other.gameObject);
            GameObject ikan;
            ikan = GameObject.FindGameObjectWithTag("Player");
            // Vector3 myScale = ikan.transform.localScale;
            ikan.transform.localScale += new Vector3(0.01f,0.01f,0);

            // myScale.x = myScale.x + 1f;
            // myScale.y = myScale.y + 1f;
            // ikan.transform.localScale = new Vector3(myScale, myScale, myScale);

            
        }
    }
}
