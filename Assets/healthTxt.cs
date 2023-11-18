using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthTxt : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text=Heart.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=Heart.health.ToString();
    }
}
