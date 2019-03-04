using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool selectState = false; //False = Left, True = Right
    public int question;

    public int catPoints = 0;

    public TextMeshProUGUI questionAsked;
    public TextMeshProUGUI responseLeft;
    public TextMeshProUGUI responseRight;

    // Start is called before the first frame update
    void Start()
    {
        questionAsked = GameObject.Find("Question").GetComponent<TextMeshProUGUI>();
        responseLeft = GameObject.Find("Response 1").GetComponent<TextMeshProUGUI>();
        responseRight = GameObject.Find("Response 2").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            selectState = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            selectState = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            question++;
            QuestionAdvance();
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void QuestionAdvance()
    {
        if (question == 0)
        {
            if(selectState == false) //Great! (Good)
            {
                catPoints++;
            }
            else if (selectState == true) //Okay... (Bad)
            {
                catPoints--;
            }
        }
        else if (question == 1)
        {
            questionAsked.text = "Are you a night owl or \nan early riser?";
            responseLeft.text = "Night Owl";
            responseRight.text = "Early Riser";

            if (selectState == false) //Night Owl (Bad)
            {
                catPoints--;
            }
            else if (selectState == true) //Early Riser (Good)
            {
                catPoints++;
            }
        }
        else if (question == 2)
        {
            questionAsked.text = "What do you like on yr pizza?";
            responseLeft.text = "Veggies";
            responseRight.text = "Anchovies";

            if (selectState == false) //Veggies (Bad)
            {
                catPoints--;
            }
            else if (selectState == true) //Anchovies (Good)
            {
                catPoints++;
            }
        }
        else if (question == 3)
        {
            questionAsked.text = "Are you allergic to cats?";
            responseLeft.text = "A little";
            responseRight.text = "Nope";

            if (selectState == false) //A little (Bad)
            {
                catPoints--;
            }
            else if (selectState == true) //Nope (Good)
            {
                catPoints++;
            }
        }
        else if (question == 4)
        {
            questionAsked.text = "How do you feel about naps?";
            responseLeft.text = "Love 'em";
            responseRight.text = "Hate 'em";

            if (selectState == false) //Love 'em (Good)
            {
                catPoints++;
            }
            else if (selectState == true) //Hate 'em (Bad)
            {
                catPoints--;
            }
        }
        else if (question == 5)
        {
            questionAsked.text = "Don't you hate birds?";
            responseLeft.text = "The most";
            responseRight.text = "Not rly";

            if (selectState == false) //The most (Good)
            {
                catPoints++;
            }
            else if (selectState == true) //Not rly (Bad)
            {
                catPoints--;
            }
        }
        else if (question == 6)
        {
            questionAsked.text = "Can I have some belly rubs?";
            responseLeft.text = "YEP";
            responseRight.text = "IDK";

            if (selectState == false) //YEP (Good)
            {
                catPoints++;
            }
            else if (selectState == true) //IDK (Bad)
            {
                catPoints--;
            }
        }
        else if (question == 7)
        {
            responseLeft.text = "";
            responseRight.text = "";

            if (catPoints > 0) //Win
            {
                questionAsked.text = "Let's be roommates!";
            }
            else if (catPoints < 0) //Lose
            {
                questionAsked.text = "I can't live with you...";
            }
        }
    }
}
