using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butttons : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Title");
    } 
     public void CREDITS()
    {
        SceneManager.LoadScene("credits");
    }
}
