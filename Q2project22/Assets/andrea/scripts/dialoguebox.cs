using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class dialoguebox : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI name;
    public TextMeshProUGUI dialoguetext;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(dialogue dialoguetext)
    {
        Animator.SetBool("IsOpen", true);
        Debug.Log("Starting text" + dialoguetext.name);
        name.text = dialoguetext.name;
        sentences.Clear();

        foreach(string sentence in dialoguetext.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialoguetext.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("end of conversation");
        Animator.SetBool("IsOpen", false);

    }
}
