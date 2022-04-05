using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject minimap;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        

        if (collider == player)
        {
            Debug.Log("set inactive");
            minimap.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other == player)
        {
            Debug.Log("set active");
            minimap.gameObject.SetActive(true);
        }
    }
}
