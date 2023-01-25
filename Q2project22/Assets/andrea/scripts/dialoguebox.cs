using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class dialoguebox : MonoBehaviour
{
    public Queue<string> sentences;
    public TextMeshProUGUI namet;
    public TextMeshProUGUI dialoguetextt;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        //sentences = new Queue<string>();
    }

    public void StartDialogue(dialogue dialoguetext)
    {
        sentences = new Queue<string>();
        Animator.SetBool("IsOpen", true);
        Debug.Log("Starting text" + dialoguetext.name);
        namet.text = dialoguetext.name;
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
        dialoguetextt.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("end of conversation");
        Animator.SetBool("IsOpen", false);

    }
}
