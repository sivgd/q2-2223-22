using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public Transform TeleportTarget;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = TeleportTarget.transform.position;
    }

}
