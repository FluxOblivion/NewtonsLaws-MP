using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject spawnedObject;
    //public Transform spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        //Instantiate(spawnedObject, spawnPoint);
        Instantiate(spawnedObject, gameObject.transform.position, Quaternion.identity);
        Debug.Log("Sphere has been spawned.");
    }
}
