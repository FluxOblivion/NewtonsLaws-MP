using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SimplePhysicsToolkit;

public class SwitchTest : MonoBehaviour
{
    public bool switchState;
    public TextMeshProUGUI textField;
    //public ZeroGravityAltered gravityField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();

        switchState = false;
        textField.SetText("DISABLED");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SwitchOn()
    //{
    //    if (switchState != true)
    //    {
    //        switchState = true;
    //        textField.text = "ON";
    //    }
    //}

    //public void SwitchOff()
    //{
    //    if (switchState != false)
    //    {
    //        switchState = false;
    //        textField.text = "OFF";
    //    }
    //}

    public void SwitchActivate()
    {
        if (switchState == false)
        {
            switchState = true;
            textField.SetText("ENABLED");
        } else
        {
            switchState = false;
            textField.SetText("DISABLED");
        }
    }
}
