using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charStewart;
    public GameObject charGranny;
    public GameObject textBox;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject correctButton;
    [SerializeField] GameObject secondButton;
    [SerializeField] GameObject thirdButton;
    [SerializeField] int eventPos = 0;

    void Update()
    {
        textLength = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        // Characters fade in
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charStewart.SetActive(true);
        charGranny.SetActive(true);
        yield return new WaitForSeconds(2);
        // Textbox appers and diologe scrolls in
        mainTextObject.SetActive(true);
        textToSpeak = "Hey kiddo, welcome to the testing page.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;
        
    }

    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Help me make sure these buttons work, click on the correct one.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        correctButton.SetActive(true);
        secondButton.SetActive(true);
        thirdButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        // Correct button clicked
        correctButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Thanks for the help kiddo!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
    }

    public void NextButton()
    {
        if(eventPos == 1)
        {
           StartCoroutine(EventOne());
        }
    }

    public void CorrectButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventTwo());
        }
    }
}
