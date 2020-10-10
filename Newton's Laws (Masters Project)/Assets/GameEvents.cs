using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }


    public event Action<int> onTriggerNextSlide;
    public void TriggerNextSlide(int slideID)
    {
        if (onTriggerNextSlide != null)
        {
            onTriggerNextSlide(slideID);
        }
    }

    public event Action<int> onTriggerPreviousSlide;
    public void TriggerPreviousSlide(int slideID)
    {
        if (onTriggerPreviousSlide != null)
        {
            onTriggerPreviousSlide(slideID);
        }
    }

    public event Action<int> onTriggerSlideChange;
    public void TriggerSlideChange(int slideID)
    {
        if (onTriggerSlideChange != null)
        {
            onTriggerSlideChange(slideID);
        }
    }

    public event Action<bool> onPlayerComplete;
    public void PlayerComplete(bool state)
    {
        if (onPlayerComplete != null)
        {
            onPlayerComplete(state);
        }
    }
}
