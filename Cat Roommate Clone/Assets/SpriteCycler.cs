using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycler : MonoBehaviour
{
    public SpriteRenderer[] sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponents<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpriteCycles()
    {
        for(int i = 0; i < 12; i++)
        {
            
        }
    }
}
