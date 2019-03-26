using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour
{
    public CanvasGroup myCG;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myCG.alpha = myCG.alpha - Time.deltaTime;
        if (myCG.alpha <= 0)
        {
            myCG.alpha = 0;
        }
    }
}
