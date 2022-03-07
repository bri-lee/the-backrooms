using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueHandler : MonoBehaviour
{
    public Canvas dialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox = GetComponent<Canvas>();
        dialogueBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
