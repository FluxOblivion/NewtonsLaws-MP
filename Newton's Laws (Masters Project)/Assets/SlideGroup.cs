using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideGroup : MonoBehaviour
{
    public int ID;
    public bool slideActive = false;
    public GameObject[] objects;
    
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onTriggerSlideChange += OnSlideChange;

    }

    void OnSlideChange(int slideID)
    {
        if (slideID != ID)
        {
            if (slideActive == true)
            {
                foreach(GameObject child in objects)
                {
                    if (child.GetComponent<SlideObject>())
                    {
                        child.GetComponent<SlideObject>().ResetObject();
                    }

                    child.SetActive(false);
                }
            }
        } else if (slideID == ID)
        {
            foreach (GameObject child in objects)
            {
                child.SetActive(true);
            }

            slideActive = true;
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onTriggerSlideChange -= OnSlideChange;
    }
}
