using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public SpriteCycler cycler;

    public Sprite[] catSprites;

    public bool _selectState = false; //False = Left, True = Right

    public string[] _questionsList;
    public string[] _leftAnswerList;
    public string[] _rightAnswerList;

    public int _question;

    public int _catPoints;

    //public float timer = 1;
    //public bool pressOK;

    public TextMeshProUGUI questionAsked;
    public TextMeshProUGUI responseLeft;
    public TextMeshProUGUI responseRight;

    // Start is called before the first frame update
    void Start()
    {
        cycler = GameObject.Find("EmojiCat").GetComponent<SpriteCycler>();

        questionAsked = GameObject.Find("Question").GetComponent<TextMeshProUGUI>();
        responseLeft = GameObject.Find("Response 1").GetComponent<TextMeshProUGUI>();
        responseRight = GameObject.Find("Response 2").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _selectState = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _selectState = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            QuestionAdvance();
            //pressOK = false;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //if(pressOK == false)
        //{
        //    timer -= Time.deltaTime;
        //    if(timer <= 0)
        //    {
        //        pressOK = true;
        //        timer = 1;
        //    }
        //}

        if (_question <= 6)
        {
            ChangeText();
        }
        else if(_question == 7)
        {
            if (_catPoints > 0) //Win
            {
                questionAsked.text = "Let's be roommates!";
                responseLeft.text = "";
                responseRight.text = "";

                cycler.sr.sprite = catSprites[1];
            }
            else if (_catPoints < 0) //Lose
            {
                questionAsked.text = "I can't live with you...";
                responseLeft.text = "";
                responseRight.text = "";

                cycler.sr.sprite = catSprites[7];
            }
        }
        

        //if (_question == 1)
        //{
        //    changeText();
        //}
        //else if (_question == 2)
        //{
        //    questionAsked.text = "What do you like on yr pizza?";
        //    responseLeft.text = "Veggies";
        //    responseRight.text = "Anchovies";
        //}
        //else if (_question == 3)
        //{
        //    questionAsked.text = "Are you allergic to cats?";
        //    responseLeft.text = "A little";
        //    responseRight.text = "Nope";
        //}
        //else if (_question == 4)
        //{
        //    questionAsked.text = "How do you feel about naps?";
        //    responseLeft.text = "Love 'em";
        //    responseRight.text = "Hate 'em";
        //}
        //else if (_question == 5)
        //{
        //    questionAsked.text = "Don't you hate birds?";
        //    responseLeft.text = "The most";
        //    responseRight.text = "Not rly";
        //}
        //else if (_question == 6)
        //{
        //    questionAsked.text = "Can I have some belly rubs?";
        //    responseLeft.text = "YEP";
        //    responseRight.text = "IDK";
        //}
        //else if (_question == 7)
        //{
        //    responseLeft.text = "";
        //    responseRight.text = "";

        //    if (_catPoints > 0) //Win
        //    {
        //        questionAsked.text = "Let's be roommates!";
        //    }
        //    else if (_catPoints < 0) //Lose
        //    {
        //        questionAsked.text = "I can't live with you...";
        //    }
        //}

    }

    void ChangeText()
    {
        questionAsked.text = _questionsList[_question];
        responseLeft.text = _leftAnswerList[_question];
        responseRight.text = _rightAnswerList[_question];
    }

    void QuestionAdvance()
    {

        if (_question == 0)
        {
            if(_selectState == false) //Great! (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[3];
            }
            else if (_selectState == true) //Okay... (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);
            }
        }
        else if (_question == 1)
        {
            //questionAsked.text = "Are you a night owl or \nan early riser?";
            //responseLeft.text = "Night Owl";
            //responseRight.text = "Early Riser";

            if (_selectState == false) //Night Owl (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[2];
            }
            else if (_selectState == true) //Early Riser (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[0];
            }
        }
        else if (_question == 2)
        {
            //questionAsked.text = "What do you like on yr pizza?";
            //responseLeft.text = "Veggies";
            //responseRight.text = "Anchovies";

            if (_selectState == false) //Veggies (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[8];
            }
            else if (_selectState == true) //Anchovies (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[2];
            }
        }
        else if (_question == 3)
        {
            //questionAsked.text = "Are you allergic to cats?";
            //responseLeft.text = "A little";
            //responseRight.text = "Nope";

            if (_selectState == false) //A little (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[9];
            }
            else if (_selectState == true) //Nope (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[5];
            }
        }
        else if (_question == 4)
        {
            //questionAsked.text = "How do you feel about naps?";
            //responseLeft.text = "Love 'em";
            //responseRight.text = "Hate 'em";

            if (_selectState == false) //Love 'em (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[11];
            }
            else if (_selectState == true) //Hate 'em (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[2];
            }
        }
        else if (_question == 5)
        {
            //questionAsked.text = "Don't you hate birds?";
            //responseLeft.text = "The most";
            //responseRight.text = "Not rly";

            if (_selectState == false) //The most (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[4];
            }
            else if (_selectState == true) //Not rly (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);

                cycler.sr.sprite = catSprites[10];
            }
        }
        else if (_question == 6)
        {
            //questionAsked.text = "Can I have some belly rubs?";
            //responseLeft.text = "YEP";
            //responseRight.text = "IDK";

            if (_selectState == false) //YEP (Good)
            {
                _catPoints++;
                Debug.Log("Right Answer, SelectState= " + _selectState + ", Question= " + _question);
            }
            else if (_selectState == true) //IDK (Bad)
            {
                _catPoints--;
                Debug.Log("Wrong Answer, SelectState= " + _selectState + ", Question= " + _question);
            }
        }
        //else if (_question == 7)
        //{
        //    responseLeft.text = "";
        //    responseRight.text = "";

        //    if (_catPoints > 0) //Win
        //    {
        //        questionAsked.text = "Let's be roommates!";
        //    }
        //    else if (_catPoints < 0) //Lose
        //    {
        //        questionAsked.text = "I can't live with you...";
        //    }
        //}
        _question++;
    }
}
