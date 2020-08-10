using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimplePhysicsToolkit
{
    public class ZeroGravityAltered : MonoBehaviour
    {

        public bool onlyAffectInteractableItems = false;

        void Start()
        {
            if (GetComponent<Collider>())
            {
                GetComponent<Collider>().isTrigger = true; //Force trigger
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Rigidbody>())
            {
                if (onlyAffectInteractableItems)
                {
                    if (other.GetComponent<InteractableItem>())
                    {
                        other.GetComponent<Rigidbody>().useGravity = false;
                        other.GetComponent<Rigidbody>().drag = 0f; //Reset Drag
                    }
                }
                else
                {
                    other.GetComponent<Rigidbody>().useGravity = false;
                    other.GetComponent<Rigidbody>().drag = 0f; //Reset Drag
                }
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.GetComponent<Rigidbody>())
            {
                if (onlyAffectInteractableItems)
                {
                    if (other.GetComponent<InteractableItem>())
                    {
                        other.GetComponent<Rigidbody>().useGravity = true;
                        other.GetComponent<Rigidbody>().drag = 0.0f; //Reset Drag
                    }
                }
                else
                {
                    other.GetComponent<Rigidbody>().useGravity = true;
                    other.GetComponent<Rigidbody>().drag = 0.0f; //Reset Drag
                }
            }
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            if (GetComponent<BoxCollider>())
            {
                Gizmos.DrawWireCube(transform.position, GetComponent<BoxCollider>().bounds.size);
            }
            else if (GetComponent<SphereCollider>())
            {
                SphereCollider c = GetComponent<SphereCollider>();
                Gizmos.DrawWireSphere(transform.position, c.radius);
            }
        }
    }
}

