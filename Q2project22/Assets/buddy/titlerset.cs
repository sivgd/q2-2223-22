using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlerset : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("p"))
        {
            Debug.Log("timtle");
            SceneManager.LoadScene("title");

        }

    }
}
