using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject minimap;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter maze");
        if (other.gameObject.tag == ("Player"))
        {
            minimap.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit maze");
        if (other.gameObject.tag == ("Player"))
        {
            minimap.gameObject.SetActive(true);
        }
    }
}
