using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charStewart;
    public GameObject charGranny;
    public GameObject textBox;
    public GameObject singleCodeLine;
    public GameObject singleFirstArrow;
    public GameObject singleSecondArrow;
    public GameObject singleThirdArrow;
    public GameObject multiFirstArrow;

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
    [SerializeField] GameObject menuButton;
    [SerializeField] GameObject retryButton;
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
        textToSpeak = "Welcome to my domain, foolish mortal.";
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
        textToSpeak = "I am the almighty Spooks, have you any questions before we begin?";
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
        textToSpeak = "Excuse you! I am no mere cat! I am the almighty Spooks! Lord of darkness! Connoisseur of Tuna!";
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
        textToSpeak = "Foolish mortal, why else would I waste my time here when I could be napping?";
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
        textToSpeak = "Via this text box below us clearly, how else would I speak to your ear-less self?";
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
        textToSpeak = "Tsk! Nevermind, today I will be enlightening you on the utility of functions.";
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
        textToSpeak = "Let us begin.";
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
        textToSpeak = "Cast your gaze upon this image before you now, mortal. For this, is a function.";
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
        textToSpeak = "It's role is to separate the lines of code according to their purpose, or their job if you will.";
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
        textToSpeak = "This way when you wish to have a task done, you need simply call upon the nessasary function.";
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
        //first image break down
        singleFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Let us examine this image more closely, begining with the function's visability.";
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
        textToSpeak = "As you can see, this function is 'Public', meaning it can be seen by all, unlike a 'Private' function.";
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
        textToSpeak = "A private function can only be seen within the class, or file essentially, that it belongs too.";
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
        textToSpeak = "There are many reasons why you would want a particular function to be private, but they are not for this lesson.";
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
        //fisrt image breakdown 1.5
        singleFirstArrow.SetActive(false);
        multiFirstArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Beside this you will find the function's 'return type', where the type of the function's output must be stated.";
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
        textToSpeak = "This function has no output, so it's type is 'void'. If it were to return an integer, you would place 'int' here. Simple as that.";
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
        //first image second break down
        multiFirstArrow.SetActive(false);
        singleSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Finally we have the functions name, which is as simple as it sounds.";
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
        textToSpeak = "Here is where you name your new function something relivant to its purpose, just as you do with all other objects.";
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
        textToSpeak = "The same naming rules apply of course, no spaces and the start must be a letter.";
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
        //first image third break down
        singleSecondArrow.SetActive(false);
        singleThirdArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Now we move on to the body of the function, which is where you place all of your code.";
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
        textToSpeak = "Here we see this function utalizing an 'if' statment. You will learn about this in another lesson.";
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
        textToSpeak = "Instead, I shall present you with an example as to why you would use a function.";
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
        textToSpeak = "Say you task your servant with fetching you tuna, and that you must give them directions on where to find it due to their incompetency.";
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
        textToSpeak = "You could tell them each time, but why waste your energy on such a thing? Why not just write it down for them?";
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
        textToSpeak = "This is the utility of functions, to write down the directions on where to find tuna and refer back to them as needed.";
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
        //wrap up
        singleCodeLine.SetActive(false);
        singleThirdArrow.SetActive(false);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Of course you must also remember to create your function before you calling upon it, you can't expect your servent to follow directions that don't exist after all.";
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

    IEnumerator EventFourty()
    {
        //start quiz or repeat
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "And thus we arrive at the end of our lesson, shall we begin the quiz?";
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
        textToSpeak = "Tsk! Fine, if I must.";
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
        correctAnswers = 0;
        menuButton.SetActive(false);
        retryButton.SetActive(false);
        quizStartButton.SetActive(false);
        repeatButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Very well, the quiz-en-ing shall commence.";
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

    //QUIZ
    IEnumerator EventFourtythree()
    {
        //quiz question 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Which of the following is NOT a use for functions?";
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
        textToSpeak = "Correct, although I would hardly complain if it could do such a thing.";
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
        textToSpeak = "Incorrect, let's move on.";
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
        textToSpeak = "True or false, a 'Public' function can be seen by all.";
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
        textToSpeak = "Correct, very well done.";
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
        textToSpeak = "Incorrect, let's move on.";
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
        textToSpeak = "What is the return type of a function that outputs an integer?";
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
        textToSpeak = "Correct, it is good to see that you can recall such things.";
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
        textToSpeak = "Incorrect, let's move on.";
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
        singleCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "True or false, the name of this function is 'CorrectButton'.";
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
        singleCodeLine.SetActive(false);
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct, one question remaining.";
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
        singleCodeLine.SetActive(false);
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Incorrect, let's move on.";
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
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "True or false, you can call a function before it has been created.";
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
        question5AButton.SetActive(false);
        question5BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct, now let us see how you did.";
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
        question5AButton.SetActive(false);
        question5BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Incorrect, let's move on to the results.";
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
        LevelRewards.lessonTwoHat = 1;
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "A perfect score, well done. Such an accomplishment deserves a reward. Here, this will do.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        menuButton.SetActive(true);
    }

    IEnumerator EventFiftynine()
    {
        //inperfect score
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "How unfortunate, it appers you've failed to meet my standards. Why not try again?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        menuButton.SetActive(true);
        retryButton.SetActive(true);
    }

    IEnumerator EventOneHundred()
    {
        //return to menu
        menuButton.SetActive(false);
        retryButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }

    public void MenuButton()
    {
        if(eventPos == 50)
        {
           StartCoroutine(EventOneHundred());
        }
    }

    public void RetryButton()
    {
        if(eventPos == 50)
        {
           StartCoroutine(EventFourtytwo());
        }
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
