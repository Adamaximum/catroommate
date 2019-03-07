using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResponseHighlight : MonoBehaviour
{
    public GameManager gm;

    public TextMeshProUGUI response;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        response = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm._selectState == false) //Left
        {
            //Debug.Log("Left Response");
            if (gameObject.name == "Response 1")
            {
                response.color = new Color32(0, 0, 0, 255);
            }
            if (gameObject.name == "Response 2")
            {
                response.color = new Color32(128, 128, 128, 255);
            }
        }

        if (gm._selectState == true) //Right
        {
            //Debug.Log("Right Response");
            if (gameObject.name == "Response 1")
            {
                response.color = new Color32(128, 128, 128, 255);
            }
            if (gameObject.name == "Response 2")
            {
                response.color = new Color32(0, 0, 0, 255);
            }
        }
    }
}
