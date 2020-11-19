using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimplePhysicsToolkit
{
    public class ZeroGravityAltered : MonoBehaviour
    {
        public bool gravityEnabled = false;

        public bool onlyAffectInteractableItems = false;
        List<Collider> affectedObjects;

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
                        affectedObjects.Add(other);
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

        private void OnTriggerStay(Collider other)
        {
            if (gravityEnabled == true)
            {
                if (other.GetComponent<Rigidbody>().useGravity && other.GetComponent<Rigidbody>().useGravity == false)
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
            } else
            {
                if (other.GetComponent<Rigidbody>().useGravity && other.GetComponent<Rigidbody>().useGravity == true)
                {
                    if (onlyAffectInteractableItems)
                    {
                        if (other.GetComponent<InteractableItem>())
                        {
                            other.GetComponent<Rigidbody>().useGravity = false;
                            other.GetComponent<Rigidbody>().drag = 0f; //Reset Drag
                            affectedObjects.Add(other);
                        }
                    }
                    else
                    {
                        other.GetComponent<Rigidbody>().useGravity = false;
                        other.GetComponent<Rigidbody>().drag = 0f; //Reset Drag
                    }
                }
            }
        }

        public void onToggle()
        {
            //Change to simple variable toggle, implement OnTriggerStay function to check variable?
            //Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);

            //foreach(Collider i in hitColliders)
            //{
            //    i.GetComponent<Rigidbody>().useGravity = true;
            //    i.GetComponent<Rigidbody>().drag = 0.0f; //Reset Drag
            //}

            if (gravityEnabled == false)
            {
                gravityEnabled = true;
            } else
            {
                gravityEnabled = false;
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

