using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycler : MonoBehaviour
{
    public GameManager gm;

    public SpriteRenderer sr;

    private string spriteNames = "emoji_cat";
    //public Sprite[] catSprites;

    public Sprite test;

    public int _frameNum;

    //public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        sr = gameObject.GetComponent<SpriteRenderer>();
        //catSprites = Resources.LoadAll<Sprite>(spriteNames);

        //catSprites = 

        //anim = gameObject.GetComponent<Animation>();
        //anim.Stop();
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
