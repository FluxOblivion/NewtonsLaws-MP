using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePhysicsToolkit;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleInteract : MonoBehaviour
{
    public InteractableItem interactScript;
    public XRGrabInteractable playerGrab;
    public Collider collisionBox;
    
    // Start is called before the first frame update
    void Start()
    {
        interactScript = GetComponent<InteractableItem>();
        playerGrab = GetComponent<XRGrabInteractable>();
        collisionBox = GetComponent<Collider>();

        interactScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerGrab.isSelected == true)
        {
            interactScript.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        interactScript.enabled = false;
    }
}
