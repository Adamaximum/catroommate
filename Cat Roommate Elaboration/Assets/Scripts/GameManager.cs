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
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

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
                cycler.sr.sprite = catSprites[3];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Okay... (Bad)
            {
                _catPoints--;

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 1)
        {
            if (_selectState == false) //Night Owl (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[2];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Early Riser (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[0];

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 2)
        {
            if (_selectState == false) //Veggies (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[8];

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Anchovies (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[2];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 3)
        {
            if (_selectState == false) //A little (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[9];

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Nope (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[5];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 4)
        {
            if (_selectState == false) //Love 'em (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[11];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Hate 'em (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[2];

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 5)
        {
            if (_selectState == false) //The most (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[4];

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //Not rly (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[10];

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        else if (_question == 6)
        {
            if (_selectState == false) //YEP (Good)
            {
                _catPoints++;

                Debug.Log("Right Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
            else if (_selectState == true) //IDK (Bad)
            {
                _catPoints--;

                Debug.Log("Wrong Answer, SelectState = " + _selectState + ", Question = " + _question);
            }
        }
        _question++;
    }
}
