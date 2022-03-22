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
        Debug.Log("Collided");

        if (other.CompareTag("Player"))
        {
            DialogueBox.enabled = true;

            Debug.Log("Tag Compared");

            // wait 3 seconds

            StartCoroutine(Stopwatch(timeForDialogue));

            Debug.Log("After Stopwatch");
        }
    }

    IEnumerator Stopwatch(int num)
    {
        yield return new WaitForSeconds(num);

        DialogueBox.enabled = false;

        Debug.Log("Inside IEnumerator");
    }
}
