using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogcounter : MonoBehaviour
{
    public float frogCount;
    public GameObject frog1;
    public GameObject frog2;
    public GameObject frog3;

    public void OnCollisionEnter(Collision thing)
    {
        if(thing.gameObject.tag == "tadpole1")
        {
            Object.Destroy(thing.gameObject);
            frogCount++;
            frog1.gameObject.SetActive(true);
        }
        if (thing.gameObject.tag == "tadpole2")
        {
            Object.Destroy(thing.gameObject);
            frogCount++;
            frog2.gameObject.SetActive(true);

        }
        if (thing.gameObject.tag == "tadpole3")
        {
            Object.Destroy(thing.gameObject);
            frogCount++;
            frog3.gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
