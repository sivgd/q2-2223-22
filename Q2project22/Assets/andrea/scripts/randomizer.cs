using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject frog1;
    public GameObject frog2;
    public GameObject frog3;
    public GameObject fp11;
    public GameObject fp12;
    public GameObject fp13;
    public GameObject fp21;
    public GameObject fp22;
    public GameObject fp23;
    public GameObject fp31;
    public GameObject fp32;
    public GameObject fp33;
    private int P1;
    private int P2;
    private int P3;

    // Start is called before the first frame update
    void Start()
    {
        P1 = Random.Range(1, 3);
        P2 = Random.Range(1, 3);
        P3 = Random.Range(1, 3);
        Setup();
    }


    public void Setup()
    {
        if(P1 == 1)
        {
            frog1.transform.position = fp11.transform.position;
        }
        if(P1 == 2)
        {
            frog1.transform.position = fp12.transform.position;
        }
        if(P1 == 3)
        {
            frog1.transform.position = fp13.transform.position;
        }
        if(P2 == 1)
        {
            frog2.transform.position = fp21.transform.position;
        }
        if(P2 == 2)
        {
            frog2.transform.position = fp22.transform.position;
        }
        if(P2 == 3)
        {
            frog2.transform.position = fp23.transform.position;

        }
        if(P3 == 1)
        {
            frog3.transform.position = fp31.transform.position;

        }
        if(P3 == 2)
        {
            frog3.transform.position = fp32.transform.position;

        }
        if(P3 == 3)
        {
            frog3.transform.position = fp33.transform.position;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
