using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript: MonoBehaviour
{
    public GameObject fuegoGO;
    float coheteSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, coheteSpeed, 0);
       
    }
    public void Despegue()

    {
        fuegoGO.SetActive(true);
        coheteSpeed = 0.1f;


    }
}
