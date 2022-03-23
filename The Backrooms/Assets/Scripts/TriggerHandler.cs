using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerHandler : MonoBehaviour
{
    public Text DialogueBox;

    [SerializeField]
    public int timeForDialogue = 3;

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

            // wait 3 seconds

            StartCoroutine(Stopwatch(timeForDialogue));
        }
    }

    IEnumerator Stopwatch(int num)
    {
        yield return new WaitForSeconds(num);

        DialogueBox.enabled = false;
    }

    void changeTextInBox(string message)
    {
        DialogueBox.text = message;
    }
}
