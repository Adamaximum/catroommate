using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycler : MonoBehaviour
{
    public SpriteRenderer[] sr;

    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponents<SpriteRenderer>();

        anim = gameObject.GetComponent<Animation>();
        anim.Stop();
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
