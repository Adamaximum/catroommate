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

        if (_question < _questionsList.Length)
        {
            ChangeText();
        }

        if (_question == 8 && _catPoints < 0)
        {
            _question = 9;
        }

        //if (_question == 8)
        //{
        //    if (_catPoints > 0) //Win
        //    {
        //        questionAsked.text = "I think that's it! I'm glad we make such great roommates!";
        //        responseLeft.text = "Play Again";
        //        responseRight.text = "Quit";

        //        cycler.sr.sprite = catSprites[1];
        //    }
        //    else if (_catPoints < 0) //Lose
        //    {
        //        questionAsked.text = "Sorry, but I don't think this arrangement will work. You should move out.";
        //        responseLeft.text = "Fine...";
        //        responseRight.text = "Fight me!";

        //        cycler.sr.sprite = catSprites[7];
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
            if(_selectState == false) //End Game
            {
                _question = 10;
                cycler.sr.sprite = catSprites[2];
            }
            else if (_selectState == true) //Begin Game
            {
                cycler.sr.sprite = catSprites[6];
            }
        }
        else if (_question == 1)
        {
            if (_selectState == false) //Sofa (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[0];
            }
            else if (_selectState == true) //Litterbox (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[5];
            }
        }
        else if (_question == 2)
        {
            if (_selectState == false) //Fur Shed (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[8];
            }
            else if (_selectState == true) //Dead Mice (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[1];
            }
        }
        else if (_question == 3)
        {
            if (_selectState == false) //Hairballs (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[10];
            }
            else if (_selectState == true) //Keyboard (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[3];
            }
        }
        else if (_question == 4)
        {
            if (_selectState == false) //Sure! (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[11];
            }
            else if (_selectState == true) //Ugh... (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[7];
            }
        }
        else if (_question == 5)
        {
            if (_selectState == false) //Of course! (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[2];
            }
            else if (_selectState == true) //Too expensive (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[8];
            }
        }
        else if (_question == 6)
        {
            if (_selectState == false) //Will do! (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[4];
            }
            else if (_selectState == true) //Ask yourself (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[9];
            }
        }
        else if (_question == 7)
        {
            if (_selectState == false) //I promise! (Good)
            {
                _catPoints++;
                cycler.sr.sprite = catSprites[1];
            }
            else if (_selectState == true) //Too busy (Bad)
            {
                _catPoints--;
                cycler.sr.sprite = catSprites[11];
            }
        }
        else if (_question == 8)
        {
            if (_selectState == false) //Play Again
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (_selectState == true) //Quit
            {
                Application.Quit();
            }
        }
        else if (_question == 9)
        {
            if (_selectState == false) //Move out
            {
                
            }
            else if (_selectState == true) //Fight
            {
                
            }
        }
        else if (_question == 10)
        {
            if (_selectState == false) //Move out
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (_selectState == true) //Fight
            {
                Application.Quit();
            }
        }

        if (_question < 8)
        {
            _question++;
        }
    }
}
