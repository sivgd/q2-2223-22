using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject frog1;
    public GameObject frog2;
    public GameObject frog3;
    public GameObject frog1pos1;
    public GameObject frog1pos2;
    public GameObject frog1pos3;
    public GameObject frog2pos1;
    public GameObject frog2pos2;
    public GameObject frog2pos3;
    public GameObject frog3pos1;
    public GameObject frog3pos2;
    public GameObject frog3pos3;
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
            frog1.transform.position = frog1pos1.transform.position;
        }
        if(P1 == 2)
        {
            frog1.transform.position = frog1pos2.transform.position;
        }
        if(P1 == 3)
        {
            frog1.transform.position = frog1pos3.transform.position;
        }
        if(P2 == 1)
        {
            frog2.transform.position = frog2pos1.transform.position;
        }
        if(P2 == 2)
        {
            frog2.transform.position = frog2pos2.transform.position;
        }
        if(P2 == 3)
        {
            frog2.transform.position = frog2pos3.transform.position;

        }
        if(P3 == 1)
        {
            frog3.transform.position = frog3pos1.transform.position;

        }
        if(P3 == 2)
        {
            frog3.transform.position = frog3pos2.transform.position;

        }
        if(P3 == 3)
        {
            frog3.transform.position = frog3pos3.transform.position;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
