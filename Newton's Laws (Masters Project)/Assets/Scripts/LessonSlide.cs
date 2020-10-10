using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "New Slide", menuName = "LessonObjects/Lesson Slide", order = 1)]
public class LessonSlide : ScriptableObject
{
    public string lessonTitle;
    [TextArea(5,10)]
    public string lessonText;

    public bool playerRequirement = false;
    
}
