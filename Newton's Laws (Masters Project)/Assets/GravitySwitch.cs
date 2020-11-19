using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePhysicsToolkit;
using TMPro;

public class GravitySwitch : MonoBehaviour
{
    public ZeroGravityAltered gravityController;
    public TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        gravityController = GetComponent<ZeroGravityAltered>();

        if (gravityController.enabled == true)
        {
            if (textField != false)
            {
                textField.SetText("DISABLED");
            }
        }
        else
        {
            if (textField != false)
            {
                textField.SetText("ENABLED");
            }
        }
    }

    public void ToggleGravity()
    {
        if (gravityController.enabled == true)
        {
            gravityController.onToggle();
            gravityController.enabled = false;
            if (textField != false)
            {
                textField.SetText("DISABLED");
            }
        } else
        {
            gravityController.enabled = true;
            if (textField != false)
            {
                textField.SetText("ENABLED");
            }
        }
    }
}
