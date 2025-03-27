using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public CoheteScript coheteScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        botonGO.SetActive(false);
        coheteScript.Despegue();
    }

    void OnMouseUp()
    {
        botonGO.SetActive(true);
    }
}
