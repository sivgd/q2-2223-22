using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    private AudioSource audioSource;
    private bool IsMoving;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0) IsMoving = true; // better use != 0 here for both directions/
        else IsMoving = false;

        if (IsMoving && !audioSource.isPlaying) audioSource.Play(); // if player is moving and audiosource is not playing play it
        if (!IsMoving) audioSource.Stop(); // if player is not moving and audiosource is playing stop it
    }
}
