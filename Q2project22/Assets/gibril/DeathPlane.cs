using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    public Transform TeleportTarget;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(5);
    }
    
}
