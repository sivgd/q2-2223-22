using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timevalue = 300;
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

        }


    }
}
