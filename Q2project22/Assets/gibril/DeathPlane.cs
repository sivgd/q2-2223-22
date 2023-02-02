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

            FindObjectOfType<PickUpController>().GetComponent<PickUpController>().equipped = false;
            FindObjectOfType<PickUpController>().GetComponent<PickUpController>().slotFull = false;
        
        SceneManager.LoadScene(5);
    }
    
}
