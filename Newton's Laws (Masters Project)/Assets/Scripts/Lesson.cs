using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New Lesson", menuName = "LessonObjects/Lesson", order = 1)]
public class Lesson : ScriptableObject
{
    //Add triggers for external events
    public LessonSlide[] slides;

    public LessonSlide GetSlide(int slideIndex)
    {
        return slides[slideIndex];
    }

    public int GetLessonLength()
    {
        return slides.Length;
    }

}
