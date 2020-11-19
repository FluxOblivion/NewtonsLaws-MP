using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    public bool isActive = false;

    Renderer currentMat;
    public Material standbyMat;
    public Material activeMat;
    
    // Start is called before the first frame update
    void Start()
    {
        currentMat = GetComponent<Renderer>();

        if (isActive)
        {
            currentMat.material = activeMat;
        } else
        {
            currentMat.material = standbyMat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ToggleMaterial();
        Destroy(other.gameObject, 0.1f);
    }

    void ToggleMaterial()
    {
        if (isActive)
        {
            currentMat.material = standbyMat;
            isActive = false;
        } else
        {
            currentMat.material = activeMat;
            isActive = true;
        }
    }
}
