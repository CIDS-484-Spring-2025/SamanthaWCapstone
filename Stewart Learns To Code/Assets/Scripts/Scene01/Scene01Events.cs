using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charStewart;
    public GameObject charGranny;
    public GameObject textBox;
    public GameObject singleCodeLine;
    public GameObject singleFirstArrow;
    public GameObject singleSecondArrow;
    public GameObject singleThirdArrow;
    public GameObject multiCodeLine;
    public GameObject multiFirstArrow;
    public GameObject multiSecondArrow;
    public GameObject swappedMultiCodeLine;
    public GameObject badMultiCodeLine;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject correctButton;
    [SerializeField] GameObject secondButton;
    [SerializeField] GameObject thirdButton;
    [SerializeField] GameObject quizStartButton;
    [SerializeField] GameObject repeatButton;
    [SerializeField] GameObject question1AButton;
    [SerializeField] GameObject question1BButton;
    [SerializeField] GameObject question1CButton;
    [SerializeField] GameObject question2AButton;
    [SerializeField] GameObject question2BButton;
    [SerializeField] GameObject question3AButton;
    [SerializeField] GameObject question3BButton;
    [SerializeField] GameObject question3CButton;
    [SerializeField] GameObject question4AButton;
    [SerializeField] GameObject question4BButton;
    [SerializeField] GameObject question5AButton;
    [SerializeField] GameObject question5BButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] int correctAnswers = 0;

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
        textToSpeak = "Hey kiddo, welcome to your first coding lesson.";
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
        textToSpeak = "What's with the look? Come on, speak up!";
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
        textToSpeak = "Ha! Course I do kiddo! We live in one!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        // Second button clicked
        correctButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Well I don't either and you're hearing me just fine, ain'tcha?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventFour()
    {
        // Third button clicked
        correctButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah fair, guess mine's like that too ain't it?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventFive()
    {
        // All options lead to here
        nextButton.SetActive(false);
        correctButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Anyway it's not like I can teach ya everything there is to know about coding, just how to read it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventSix()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Speaking of, let's get started!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventSeven()
    {
        singleCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Have a look at this photo kiddo, this right here is a line of code.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventEight()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "It's job is to give this ol' computer a single task to complete, one with no room for interpretation.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventNine()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Why's it gotta be so specific? Because computers are dumb Kiddo, and I mean real dumb.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 8;
    }

    IEnumerator EventTen()
    {
        singleFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Let's break this down into bits so you see what I mean.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 9;
    }

    IEnumerator EventEleven()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Here we're asking the computer to make us an object, and this part here says what type it's gotta be.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 10;
    }

    IEnumerator EventTwelve()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "In this case, we're saying that we want it to be an 'integer', basically a bucket for holding whole numbers.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 11;
    }

    IEnumerator EventThirteen()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "If we wanted it to hold a string of text instead, we'd tell it to make 'string' type.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 12;
    }

    IEnumerator EventFourteen()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "There's also 'boolean' for true or false, and 'float' for decimal numbers.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 13;
    }

    IEnumerator EventFifteen()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "You've got a couple others types as well, but these four are all you gotta know for now.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 14;
    }

    IEnumerator EventSixteen()
    {
        singleFirstArrow.SetActive(false);
        singleSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Now let's talk about this bit, which is what we're telling the computer to call the object.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 15;
    }

    IEnumerator EventSeventeen()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "This bit's pretty straight forward, just name the thing something relivant to it's purpose and you're set.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 16;
    }

    IEnumerator EventEightteen()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Just keep in mind that you can't use spaces and it's gotta start with a letter, or else it'll yell at ya.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 17;
    }

    IEnumerator EventNineteen()
    {
        singleSecondArrow.SetActive(false);
        singleThirdArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Now on to the last bit, which is us telling the computer what to start the object out with.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 18;
    }

    IEnumerator EventTwenty()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Since this one's for holding numbers, here we're telling it to start out with a zero in it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 19;
    }

    IEnumerator EventTwentyone()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Other types work like this too, for strings though you gotta put them in quotation marks.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 20;
    }

    IEnumerator EventTwentytwo()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Why's that you ask? Well to make a long answer short the string type's a bit more than just a 'bucket'.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 21;
    }

    IEnumerator EventTwentythree()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "A lot of the time it involves something called an 'array', and that's a topic for a whole other lesson.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 22;
    }

    IEnumerator EventTwentyfour()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Point is that whatever's after the equal sign is what's in the object. Until...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 23;
    }

    IEnumerator EventTwentyfive()
    {
        singleThirdArrow.SetActive(false);
        singleCodeLine.SetActive(false);
        multiCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "You tell the ol' hunk of metal to replace it using another line. Which brings us to my last topic, order!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 24;
    }

    IEnumerator EventTwentysix()
    {
        multiFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Have a look here, this is us telling the computer to replace what's currently in the object with a 1.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 25;
    }

    IEnumerator EventTwentyseven()
    {
        multiFirstArrow.SetActive(false);
        multiSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And down here we're telling it again to replace what's inside, but this time with a 42.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 26;
    }

    IEnumerator EventTwentyeight()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Now if we asked the computer what's inside our object, it'll tell us 42.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 27;
    }

    IEnumerator EventTwentynine()
    {
        multiSecondArrow.SetActive(false);
        multiCodeLine.SetActive(false);
        swappedMultiCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Buuut if we instead swaped these around and asked it, it'd instead tell us there's a 1.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 28;
    }

    IEnumerator EventThirdy()
    {
        multiFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "This is because of the order we're giving the tasks in, with the top task being the first one.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 29;
    }

    IEnumerator EventThirdyone()
    {
        multiFirstArrow.SetActive(false);
        multiSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And the bottom one being the last one, or most recent if you'd like to think of it that way.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 30;
    }

    IEnumerator EventThirdytwo()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Sounds simple enough, yeah? Well there's one major reason why I'm teaching ya this.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 31;
    }

    IEnumerator EventThirdythree()
    {
        swappedMultiCodeLine.SetActive(false);
        multiSecondArrow.SetActive(false);
        badMultiCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And it's that the computer can only read in that exact order.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 32;
    }
    IEnumerator EventThirdyfour()
    {
        multiSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Remember this line Kiddo? This is us telling the computer to make us an object.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 33;
    }

    IEnumerator EventThirdyfive()
    {
        multiSecondArrow.SetActive(false);
        multiFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "But up here we're telling it to put a 1 in that object.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 34;
    }

    IEnumerator EventThirdysix()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Now you and I can clearly see what object we're refering to, but the computer? It don't see nothin'.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 35;
    }

    IEnumerator EventThirdyseven()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "From it's perspective, you're telling it to put a 1 in a non-existant bucket, which it can't do.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 36;
    }

    IEnumerator EventThirdyeight()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And what's the computer gonna do if it can't do it's task? It's gonna yell at ya too fix it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 37;
    }

    IEnumerator EventThirdynine()
    {
        multiFirstArrow.SetActive(false);
        badMultiCodeLine.SetActive(false);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "This'll be important when you learn about functions as the same goes for them, so remember it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 38;
    }

    IEnumerator EventFourty()
    {
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And with that I've told ya all I know Kiddo, ready for me to quiz ya?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        quizStartButton.SetActive(true);
        repeatButton.SetActive(true);
        eventPos = 39;
    }

    IEnumerator EventFourtyone()
    {
        //restart lesson
        quizStartButton.SetActive(false);
        repeatButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Sure thing Kiddo, let's start from the top.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFourtytwo()
    {
        //start quiz
        quizStartButton.SetActive(false);
        repeatButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Great, then let's get started!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 40;
    }

    IEnumerator EventFourtythree()
    {
        //quiz question 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "What type of object is used for holding whole numbers?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question1AButton.SetActive(true);
        question1BButton.SetActive(true);
        question1CButton.SetActive(true);
        eventPos = 41;
    }

    IEnumerator EventFourtyfour()
    {
        //quiz question 1 correct
        correctAnswers++;
        question1AButton.SetActive(false);
        question1BButton.SetActive(false);
        question1CButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Good job Kiddo! Onto the next one!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 42;
    }

    IEnumerator EventFourtyfive()
    {
        //quiz question 1 incorrect
        question1AButton.SetActive(false);
        question1BButton.SetActive(false);
        question1CButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah sorry Kiddo, that's not quite it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 42;
    }

    IEnumerator EventFourtysix()
    {
        //quiz question 2
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "True or false, the type boolean is used for holding true or false values.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question2AButton.SetActive(true);
        question2BButton.SetActive(true);
        eventPos = 43;
    }

    IEnumerator EventFourtyseven()
    {
        //quiz question 2 correct
        correctAnswers++;
        question2AButton.SetActive(false);
        question2BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Good job Kiddo! Onto the next one!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 44;
    }

    IEnumerator EventFourtyeight()
    {
        //quiz question 2 incorrect
        question2AButton.SetActive(false);
        question2BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah sorry Kiddo, that's not quite it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 44;
    }

    IEnumerator EventFourtynine()
    {
        //quiz question 3
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "What does an object name have to start with?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question3AButton.SetActive(true);
        question3BButton.SetActive(true);
        question3CButton.SetActive(true);
        eventPos = 45;
    }

    IEnumerator EventFifty()
    {
        //quiz question 3 correct
        correctAnswers++;
        question3AButton.SetActive(false);
        question3BButton.SetActive(false);
        question3CButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Good job Kiddo! Onto the next one!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 46;
    }

    IEnumerator EventFiftyone()
    {
        //quiz question 3 incorrect
        question3AButton.SetActive(false);
        question3BButton.SetActive(false);
        question3CButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah sorry Kiddo, that's not quite it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 46;
    }

    IEnumerator EventFiftytwo()
    {
        //quiz question 4
        multiCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "What number is currently inside the object?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question4AButton.SetActive(true);
        question4BButton.SetActive(true);
        eventPos = 47;
    }

    IEnumerator EventFiftythree()
    {
        //quiz question 4 correct
        correctAnswers++;
        multiCodeLine.SetActive(false);
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Good job Kiddo! Onto the next one!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 48;
    }

    IEnumerator EventFiftyfour()
    {
        //quiz question 4 incorrect
        multiCodeLine.SetActive(false);
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah sorry Kiddo, that's not quite it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 48;
    }

    IEnumerator EventFiftyfive()
    {
        //quiz question 5
        badMultiCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Last one, what's wrong with this picture?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question5AButton.SetActive(true);
        question5BButton.SetActive(true);
        eventPos = 49;
    }

    IEnumerator EventFiftysix()
    {
        //quiz question 5 correct
        correctAnswers++;
        badMultiCodeLine.SetActive(false);
        question5AButton.SetActive(false);
        question5BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Good job Kiddo! Let's see how you did!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 50;
    }

    IEnumerator EventFiftyseven()
    {
        //quiz question 5 incorrect
        badMultiCodeLine.SetActive(false);
        question5AButton.SetActive(false);
        question5BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah sorry Kiddo, that's not quite it. Let's see how you did.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 50;
    }

    IEnumerator EventFiftyeight()
    {
        //perfect score (5/5)
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Five out of five, a perfect score! Way to go Kiddo!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator EventFiftynine()
    {
        //inperfect score
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Gah seems ya didn't quite make it Kiddo, how's about we try again from the top?";
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
        if(eventPos == 3)
        {
           StartCoroutine(EventFive());
        }
        if(eventPos == 4)
        {
           StartCoroutine(EventSix());
        }
        if(eventPos == 5)
        {
           StartCoroutine(EventSeven());
        }
        if(eventPos == 6)
        {
           StartCoroutine(EventEight());
        }
        if(eventPos == 7)
        {
           StartCoroutine(EventNine());
        }
        if(eventPos == 8)
        {
           StartCoroutine(EventTen());
        }
        if(eventPos == 9)
        {
           StartCoroutine(EventEleven());
        }
        if(eventPos == 10)
        {
           StartCoroutine(EventTwelve());
        }
        if(eventPos == 11)
        {
           StartCoroutine(EventThirteen());
        }
        if(eventPos == 12)
        {
           StartCoroutine(EventFourteen());
        }
        if(eventPos == 13)
        {
           StartCoroutine(EventFifteen());
        }
        if(eventPos == 14)
        {
           StartCoroutine(EventSixteen());
        }
        if(eventPos == 15)
        {
           StartCoroutine(EventSeventeen());
        }
        if(eventPos == 16)
        {
           StartCoroutine(EventEightteen());
        }
        if(eventPos == 17)
        {
           StartCoroutine(EventNineteen());
        }
        if(eventPos == 18)
        {
           StartCoroutine(EventTwenty());
        }
        if(eventPos == 19)
        {
           StartCoroutine(EventTwentyone());
        }
        if(eventPos == 20)
        {
           StartCoroutine(EventTwentytwo());
        }
        if(eventPos == 21)
        {
           StartCoroutine(EventTwentythree());
        }
        if(eventPos == 22)
        {
           StartCoroutine(EventTwentyfour());
        }
        if(eventPos == 23)
        {
           StartCoroutine(EventTwentyfive());
        }
        if(eventPos == 24)
        {
           StartCoroutine(EventTwentysix());
        }
        if(eventPos == 25)
        {
           StartCoroutine(EventTwentyseven());
        }
        if(eventPos == 26)
        {
           StartCoroutine(EventTwentyeight());
        }
        if(eventPos == 27)
        {
           StartCoroutine(EventTwentynine());
        }
        if(eventPos == 28)
        {
           StartCoroutine(EventThirdy());
        }
        if(eventPos == 29)
        {
           StartCoroutine(EventThirdyone());
        }
        if(eventPos == 30)
        {
           StartCoroutine(EventThirdytwo());
        }
        if(eventPos == 31)
        {
           StartCoroutine(EventThirdythree());
        }
        if(eventPos == 32)
        {
           StartCoroutine(EventThirdyfour());
        }
        if(eventPos == 33)
        {
           StartCoroutine(EventThirdyfive());
        }
        if(eventPos == 34)
        {
           StartCoroutine(EventThirdysix());
        }
        if(eventPos == 35)
        {
           StartCoroutine(EventThirdyseven());
        }
        if(eventPos == 36)
        {
           StartCoroutine(EventThirdyeight());
        }
        if(eventPos == 37)
        {
           StartCoroutine(EventThirdynine());
        }
        if(eventPos == 38)
        {
           StartCoroutine(EventFourty());
        }
        if(eventPos == 40)
        {
           StartCoroutine(EventFourtythree());
        }
        if(eventPos == 42)
        {
           StartCoroutine(EventFourtysix());
        }
        if(eventPos == 44)
        {
           StartCoroutine(EventFourtynine());
        }
        if(eventPos == 46)
        {
           StartCoroutine(EventFiftytwo());
        }
        if(eventPos == 48)
        {
           StartCoroutine(EventFiftyfive());
        }
        if(correctAnswers == 5 && eventPos == 50)
        {
           StartCoroutine(EventFiftyeight());
        }
        if(correctAnswers != 5 && eventPos == 50)
        {
           StartCoroutine(EventFiftynine());
        }
    }

    public void CorrectButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventTwo());
        }
    }

    public void SecondButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventThree());
        }
    }

    public void ThirdButton()
    {
        if(eventPos == 2)
        {
           StartCoroutine(EventFour());
        }
    }

    public void QuizStartButton()
    {
        if(eventPos == 39)
        {
           StartCoroutine(EventFourtytwo());
        }
    }

    public void RepeatButton()
    {
        if(eventPos == 39)
        {
           StartCoroutine(EventFourtyone());
        }
    }

    public void Question1AButton()
    {
        if(eventPos == 41)
        {
           StartCoroutine(EventFourtyfour());
        }
    }
    public void Question1BButton()
    {
        if(eventPos == 41)
        {
           StartCoroutine(EventFourtyfive());
        }
    }
    public void Question1CButton()
    {
        if(eventPos == 41)
        {
           StartCoroutine(EventFourtyfive());
        }
    }
    public void Question2AButton()
    {
        if(eventPos == 43)
        {
           StartCoroutine(EventFourtyeight());
        }
    }
    public void Question2BButton()
    {
        if(eventPos == 43)
        {
           StartCoroutine(EventFourtyseven());
        }
    }
    public void Question3AButton()
    {
        if(eventPos == 45)
        {
           StartCoroutine(EventFiftyone());
        }
    }
    public void Question3BButton()
    {
        if(eventPos == 45)
        {
           StartCoroutine(EventFifty());
        }
    }
    public void Question4BButton()
    {
        if(eventPos == 47)
        {
           StartCoroutine(EventFiftythree());
        }
    }
    public void Question4AButton()
    {
        if(eventPos == 47)
        {
           StartCoroutine(EventFiftyfour());
        }
    }
    public void Question5AButton()
    {
        if(eventPos == 49)
        {
           StartCoroutine(EventFiftysix());
        }
    }
    public void Question5BButton()
    {
        if(eventPos == 49)
        {
           StartCoroutine(EventFiftyseven());
        }
    }
}
