using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObject : MonoBehaviour
{
    Vector3 startPosition;
    Quaternion startRotation;
    Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        startRotation = this.transform.rotation;
        startScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetObject()
    {
        this.transform.position = startPosition;
        this.transform.rotation = startRotation;
        this.transform.localScale = startScale;

        //anything else needed?
    }
}
