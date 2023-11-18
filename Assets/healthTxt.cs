using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class healthTxt : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text=System.Math.Floor(Heart.health).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=System.Math.Floor(Heart.health).ToString();
    }
}
