using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbtialRotate : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    //public GameObject mesh;
    //Vector3 rotationStep;

    // Start is called before the first frame update
    void Start()
    {
        //rotationStep = new Vector3(0.0f, rotationSpeed, 0.0f);
        //mesh = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
