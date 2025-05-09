using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject plotText;

    [SerializeField] GameObject startButton;
    [SerializeField] GameObject plotButton;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject lessononeButton;
    [SerializeField] GameObject lessontwoButton;
    [SerializeField] GameObject lessonthreeButton;
    [SerializeField] int eventPos = 0;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        // fade in
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        //start button
        startButton.SetActive(false);
        plotButton.SetActive(false);
        lessononeButton.SetActive(true);
        lessontwoButton.SetActive(true);
        lessonthreeButton.SetActive(true);
        backButton.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        eventPos = 2;

    }

    IEnumerator EventTwo()
    {
        //plot button
        startButton.SetActive(false);
        plotButton.SetActive(false);
        plotText.SetActive(true);
        backButton.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        //back button
        startButton.SetActive(true);
        plotButton.SetActive(true);
        plotText.SetActive(false);
        backButton.SetActive(false);
        lessononeButton.SetActive(false);
        lessontwoButton.SetActive(false);
        lessonthreeButton.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        eventPos = 1;
    }

    IEnumerator EventFour()
    {
        //lesson 1 button
        backButton.SetActive(false);
        lessononeButton.SetActive(false);
        lessontwoButton.SetActive(false);
        lessonthreeButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 4;
        SceneManager.LoadScene(1);
    }

    IEnumerator EventFive()
    {
        //lesson 2 button
        backButton.SetActive(false);
        lessononeButton.SetActive(false);
        lessontwoButton.SetActive(false);
        lessonthreeButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 4;
        SceneManager.LoadScene(2);
    }

    IEnumerator EventSix()
    {
        //lesson 3 button
        backButton.SetActive(false);
        lessononeButton.SetActive(false);
        lessontwoButton.SetActive(false);
        lessonthreeButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 4;
        SceneManager.LoadScene(3);
    }

    public void StartButton()
    {
        if(eventPos == 1)
        {
           StartCoroutine(EventOne());
        }
    }

    public void PlotButton()
    {
        if(eventPos == 1)
        {
           StartCoroutine(EventTwo());
        }
    }

    public void BackButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventThree());
        }
        if(eventPos == 3)
        {
           StartCoroutine(EventThree());
        }
    }

    public void LessonOneButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventFour());
        }
    }

    public void LessonTwoButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventFive());
        }
    }

    public void LessonThreeButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventSix());
        }
    }
}
