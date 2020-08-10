using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePhysicsToolkit;

public class GravitySwitch : MonoBehaviour
{
    public ZeroGravity gravityController;
    
    // Start is called before the first frame update
    void Start()
    {
        gravityController = GetComponent<ZeroGravity>();
    }

    public void ToggleGravity()
    {
        if (gravityController.enabled == true)
        {
            gravityController.enabled = false;
        } else
        {
            gravityController.enabled = true;
        }
    }
}
