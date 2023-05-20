using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialUI : MonoBehaviour
{
    public TMP_Text panel;

    void Start()
    {
        string start_text = "Move with the arrows and space";
        Tutorial(ref start_text); 
    }

    public void Tutorial(ref string message)
    {
        panel.text = message;
    }
}
