using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeinseconds = 300;
    public TextMeshProUGUI timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeinseconds > 0)
        {
            timeinseconds -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("lose");
        }

        DisplayTime(timeinseconds);
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
