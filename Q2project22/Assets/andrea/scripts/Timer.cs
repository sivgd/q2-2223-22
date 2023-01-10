using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timevalue = 300;
    public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timevalue > 0)
        {
        timevalue -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("lose");
        }

        DisplayTime(timevalue);
    }

    void DisplayTime(float timetodisplay)
    {
        if(timetodisplay <0)
        {
            timetodisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timetodisplay / 60);
        float seconds = Mathf.FloorToInt(timetodisplay % 60);

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
