using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene03Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charStewart;
    public GameObject charGranny;
    public GameObject textBox;
    public GameObject singleCodeLine;
    public GameObject ifElsePic;
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
        textToSpeak = "Hey there If-ewart! Welcome to your third lesson!";
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
        textToSpeak = "Name's Kevin, but you can call me If-vin! Can ya guess why? Come on, guess!";
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
        textToSpeak = "Right on If-ewart! But only IF you wanna learn about them! Get it? Because I'm teaching you about-";
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
        textToSpeak = "Maaaan what kind of guess is that? If you wanna know you could just go ask... Oh! Hey! If! Ha! I didn't even mean to do that one!";
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
        textToSpeak = "Heh, what's wrong If-ewart? Not a if-an of puns? Gonna blow a if-use if I make a if-ew more? You ain't got no arms to stop me with! Ha!";
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
        textToSpeak = "AAAnyway, if-heh-you couldn't tell I'm gonna be the one teaching you about if statements. Which are the best statements IF you ask me!";
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
        textToSpeak = "Ah, and don't worry, I'll cool it with the if puns from here on out. Gonna be hard for you to focus if you're laughing the whole time, ya know? Now let's get started!";
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
        textToSpeak = "Check out this picture I totally didn't steal from Spooks! It's got an if statement in it!";
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
        textToSpeak = "If statements are for when you want code to only be followed under specific circumstances. Like only if something is true or only if something is the same as something else!";
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
        textToSpeak = "Granny told you all about how specific you have to be with computers, yeah? Well think of this like specifically telling it if it's allowed to do something or not!";
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
        textToSpeak = "Let's check out how we tell it what the if condition is with this line right here.";
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
        textToSpeak = "See how it starts with an 'if'? This lets the computer know that the condition in the parentheses will determine if the code in the curly brackets should be followed or ignored.";
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
        textToSpeak = "It decides that by checking if the condition is true or false. If it's true, it executes the code! If it's false, it ignores it and moves on to whatever's after the if statement.";
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
        textToSpeak = "So tecnically you could just put true or false for the condition and have it always execute or always ignore. Not sure why you'd want to, but you can!";
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
        //first image second break down
        singleFirstArrow.SetActive(false);
        singleSecondArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Next we've got the condition itself, and these can look all sorts of ways but most of the time they'll look like this one.";
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
        textToSpeak = "You see these two equal signs here? This is the coding equivalent to 'does this thing equal that thing'. Like a normal equal sign, but longer because the short one now means 'put this thing in here'.";
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
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "So in this case, this condition says that if 'eventPos' is equal to 2, then the computer's allowed to execute the code inside!";
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
        textToSpeak = "You can do this with booleans and strings too! It's just that for booleans you have to ask if it's equal to true or false, and for strings you check to see if it matches exactly.";
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
        textToSpeak = "And I mean like, exactly exactly, for strings just so you know. Like password level of exactly since it's comparing the actual characters in the string. So keep that in mind.";
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
        //if else transition
        singleSecondArrow.SetActive(false);
        singleCodeLine.SetActive(false);
        ifElsePic.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Finally I've got one last thing to talk about, if else statements! They're basically if statements, but longer!";
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
        singleThirdArrow.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Remember how I said that all the code in the if statement gets ignored if the condition is false? Well if you just put 'else' here, you can tell the computer to do something instead!";
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
        textToSpeak = "So in this case if 'eventPos' isn't equal to 2, instead of ignoring this the computer will instead run uh...whatever event three is!";
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
        textToSpeak = "You can actually chain if statements this way too, just put an if statement inside of the else, or even right beside it.";
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
        textToSpeak = "Be careful if you try that though, it can get really messy really fast and if you miss a pair of parentheses somewhere you'll be in for a world of pain.";
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
        ifElsePic.SetActive(false);
        singleThirdArrow.SetActive(false);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "But aside from that, we're pretty much done! There's also these things called 'case' statements that work a lot like if statements, but they're harder to make puns out of so I'm not gonna cover them.";
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
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Ah, and in case no one's told you yet, remember that depending on the coding language you use all this stuff is gonna look and work a little diffrent. We're just teaching you the general stuff.";
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
        textToSpeak = "But enough of that, ready to get quizzed?";
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
        textToSpeak = "Sure! As many times as you'd like!";
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
        textToSpeak = "Yippie! Let's get started!";
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

    //QUIZ               ***********************************
    IEnumerator EventFourtythree()
    {
        //quiz question 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "When should you use if statements?";
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
        textToSpeak = "Correct! That's one down!";
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
        textToSpeak = "Incorrect, no worries though! Let's check out the next one!";
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
        singleCodeLine.SetActive(true);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "What's the if condition in this picture?";
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
        singleCodeLine.SetActive(false);
        question2AButton.SetActive(false);
        question2BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Only three more to go!";
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
        singleCodeLine.SetActive(false);
        question2AButton.SetActive(false);
        question2BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Incorrect, no worries though! Let's check out the next one!";
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
        textToSpeak = "True or false, for an if else statement, the code in the else section WILL run if the if condition is true.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        question3AButton.SetActive(true);
        question3BButton.SetActive(true);
        eventPos = 45;
    }

    IEnumerator EventFifty()
    {
        //quiz question 3 correct
        correctAnswers++;
        question3AButton.SetActive(false);
        question3BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! You're doing great!";
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
        textBox.SetActive(true);
        textToSpeak = "Incorrect, no worries though! Let's check out the next one!";
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
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "True or false, using just one equal sign means 'if this is the same as that'.";
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
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Correct! Just one question to go!";
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
        question4AButton.SetActive(false);
        question4BButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "Incorrect, no worries though! Let's check out the next one!";
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
        textToSpeak = "True or false, for a string if condition, both strings must match exactly, down to the characters themselves.";
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
        textToSpeak = "Correct! Let us see how you did!";
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
        textToSpeak = "Incorrect, no worries though! Let's check out how you did.";
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
        LevelRewards.lessonThreeHat = 1;
        nextButton.SetActive(false);
        textBox.SetActive(true);
        textToSpeak = "A perfect score! I knew you could do it! Here's your prize!";
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
        textToSpeak = "Awww man, looks like you need to study up. Maybe give it another shot?";
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
