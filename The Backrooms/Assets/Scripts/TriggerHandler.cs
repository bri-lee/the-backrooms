using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerHandler : MonoBehaviour
{

    public Text DialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        DialogueBox.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueBox.enabled = true;
        }
    }
}
