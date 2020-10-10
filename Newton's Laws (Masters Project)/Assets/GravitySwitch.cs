using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePhysicsToolkit;

public class GravitySwitch : MonoBehaviour
{
    public ZeroGravityAltered gravityController;
    
    // Start is called before the first frame update
    void Start()
    {
        gravityController = GetComponent<ZeroGravityAltered>();
    }

    public void ToggleGravity()
    {
        if (gravityController.enabled == true)
        {
            gravityController.onToggle();
            gravityController.enabled = false;
            Debug.Log("Gravity Disabled.");
        } else
        {
            gravityController.enabled = true;
            Debug.Log("Gravity Enabled.");
        }
    }
}
