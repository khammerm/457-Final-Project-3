using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{

    public int ammo = 25;
    public bool gunFiring = false;

    public Text weaponName;
    public Text ammoText;
    public GameObject reloadingText;
    // Start is called before the first frame update
    void Start()
    {
        reloadingText.gameObject.SetActive(false);
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) && !gunFiring && ammo>0)
        {
            gunFiring = true;
            ammo--;
            UpdateTexts();
            gunFiring = false;
        }

        if (ammo == 0 || Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("got here");

            ReloadWeapon();

        }

        UpdateTexts();
        
    }


    void UpdateTexts()
    {
        ammoText.text = ammo.ToString();
        
    }

    void ReloadWeapon()
    {
        if (ammo == 0 && Input.GetKeyDown(KeyCode.R))
        {
            reloadingText.gameObject.SetActive(true);

            
            ammo = 400;
            reloadingText.gameObject.SetActive(false);


        }
        

    }

    IEnumerator Waiter()
    {
        if (ammo == 0 || Input.GetKeyDown(KeyCode.R))
        {
            reloadingText.gameObject.SetActive(true);

            
            ammo = 400;
            yield return new WaitForSeconds(2);
            reloadingText.gameObject.SetActive(false);


        }

        

     
    }
}
