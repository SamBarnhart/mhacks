using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public static int health=50;
    public Sprite heart1;
    public Sprite heart2;
    public Sprite heart3;
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
        }else if(health>=0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite=heart3;
        }

    }
}
