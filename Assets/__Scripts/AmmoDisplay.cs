using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{

    public int ammo = 25;
    public bool gunFiring = false;

    public bool isReloading = false;

    public Text weaponName;
    public Text ammoText;
    public GameObject reloadingText;
    // Start is called before the first frame update
    void Start()
    {
        gunFiring = false;
        isReloading = false;
        reloadingText.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) && !gunFiring && ammo>0 && isReloading ==false)
        {
            gunFiring = true;
            ammo--;
            UpdateTexts();
            gunFiring = false;
            
        }




        ReloadWeapon();

        UpdateTexts();
        
    }


    void UpdateTexts()
    {
        ammoText.text = ammo.ToString();
        
    }

    void ReloadWeapon()
    {
        if (ammo == 0 || Input.GetKeyDown(KeyCode.R))
        {
            if(ammo != 400)
            {
                isReloading = true;
                gunFiring = false;
                reloadingText.gameObject.SetActive(true);
                StartCoroutine(Waiter());

            }
            
            


        }
        

    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);

        ammo = 500;
        
            
        reloadingText.gameObject.SetActive(false);

        isReloading = false;

    }




}

