using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnmono;
    private Vector3 positionspawn;
    private float startDelay = 2;
    private float repeat = 2;
    private PlayerController PlayerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", startDelay, repeat);
        
    }

     void Update()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
       
    }
    void SpawnObject()
    {    
        if (PlayerScript.GameOver == false)
        {
            positionspawn = new Vector3(transform.position.x, Random.Range(-5, 0), transform.position.z);
            Instantiate(spawnmono, positionspawn, spawnmono.transform.rotation);
        }
    }
}
