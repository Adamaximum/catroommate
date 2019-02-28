using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textStuff;
    
    public void ChangeText()
    {
        int randNum;
        randNum = Random.Range(0, textStuff.Length);

        text.text = textStuff[randNum];
    }
}
