using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textbox : MonoBehaviour
{
    public InputField text_area; // Declare inputtext variable
    public Text gbttext; // Declare gbttext variable

    void Start()
    {
        // Add an event listener to the text_area's OnEndEdit event
        text_area.onEndEdit.AddListener(OnEnter);
    }

    void OnEnter(string userInput)
    {
        // Set the value of gbttext to the user input
        gbttext.text = userInput;
    }
}
