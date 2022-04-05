using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject minimap;
    public GameObject maze;

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
        

        if (collider.gameObject.tag == "Maze")
        {
            RenderSettings.fog = true;
            minimap.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Maze")
        {
            RenderSettings.fog = false;
            minimap.gameObject.SetActive(true);
        }
    }
}
