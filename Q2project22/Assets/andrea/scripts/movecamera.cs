using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
