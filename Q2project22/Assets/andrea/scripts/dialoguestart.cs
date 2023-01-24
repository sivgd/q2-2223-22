using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguestart : MonoBehaviour
{
    public dialogue Dialogue;
    public void Start()
    {
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<dialoguebox>().StartDialogue(Dialogue);
    }
}
