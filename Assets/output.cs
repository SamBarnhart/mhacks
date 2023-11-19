using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class output : MonoBehaviour
{
    public Text text; // Reference to the Text component

    // Start is called before the first frame update
    void Start()
    {
        text.text = input.outfacingtxt;
    }

    // Update is called once per frame
    // BEGIN: ed8c6549bwf9
    void Update()
    {
        //Debug.Log(input.inputtxt);
        text.text = input.outfacingtxt; // Set the text of the object to input.inputtext
    }
    // END: ed8c6549bwf9
}
