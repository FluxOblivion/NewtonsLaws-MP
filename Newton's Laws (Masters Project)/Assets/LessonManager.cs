using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LessonManager : MonoBehaviour
{
    public static LessonManager current;

    private void Awake()
    {
        current = this;
    }

    //Will have to replace with more robust system later
    public Lesson currentLesson;
    LessonSlide currentSlide;

    public TextMeshProUGUI lessonTitle;
    public TextMeshProUGUI lessonText;

    public TextMeshProUGUI currentSlideBox;
    public TextMeshProUGUI totalSlidesBox;

    int slideCount;
    int slideTotal;

    // Start is called before the first frame update
    void Start()
    {
        slideTotal = currentLesson.GetLessonLength();
        totalSlidesBox.text = slideTotal.ToString();
        slideCount = 0;

        NextSlide();
    }

    // Make global event
    public void NextSlide()
    {
        if (slideCount <= slideTotal)
        {
            //Trigger event

            currentSlide = currentLesson.GetSlide(slideCount);

            lessonTitle.text = currentSlide.lessonTitle.ToString();
            lessonText.text = currentSlide.lessonText.ToString();

            currentSlideBox.text = (slideCount + 1).ToString();
            slideCount++;

            GameEvents.current.TriggerSlideChange(slideCount);
        }
    }

    // Make global event
    public void PreviousSlide()
    {
        if (slideCount > 0)
        {
            //Trigger Event

            currentSlide = currentLesson.GetSlide(slideCount-1);

            lessonTitle.text = currentSlide.lessonTitle.ToString();
            lessonText.text = currentSlide.lessonText.ToString();

            currentSlideBox.text = slideCount.ToString();
            slideCount--;

            GameEvents.current.TriggerSlideChange(slideCount);
        }
    }
}
