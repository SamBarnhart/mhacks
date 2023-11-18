using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public static double health=100;
    public Sprite heart1;
    public Sprite heart2;
    public Sprite heart3;
    public Sprite heart4;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite=heart1;
    }

    // Update is called once per frame
    void Update()
    {
        if(health>=66){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=heart1;
        }else if(health>=33){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=heart2;
        }else if(health>=1){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=heart3;
        }else if(health<1){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=heart4;
        }
        if(health>1)
            health-=.01;
    }
}
