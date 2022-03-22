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
    public Text reloadingText;
    // Start is called before the first frame update
    void Start()
    {
        reloadingText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) && !gunFiring && ammo>0)
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
        if (ammo == 0 || Input.GetKeyDown(KeyCode.R))
        {
            reloadingText.enabled = true;

            //NEED TO ADD A DELAY HERE TO SHOW RELOADING TEXT
            //yield return new WaitForSeconds(3);
            ammo = 25;
            reloadingText.enabled = false;


        }
        

    }

    IEnumerator waiter()
    {
        //Rotate 90 deg
        transform.Rotate(new Vector3(90, 0, 0), Space.World);

        //Wait for 4 seconds
        yield return new WaitForSeconds(4);

        //Rotate 40 deg
        transform.Rotate(new Vector3(40, 0, 0), Space.World);

        //Wait for 2 seconds
        yield return new WaitForSeconds(2);

        //Rotate 20 deg
        transform.Rotate(new Vector3(20, 0, 0), Space.World);
    }
}
