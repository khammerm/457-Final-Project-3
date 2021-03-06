using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{

    public int ammo = 25;
    public bool gunFiring = false;

    public bool isReloading = false;

    public WeaponSwitching script;
    public Text weaponName;
    public Text ammoText;
    public GameObject reloadingText;


    public Text targetsKilledText;
    public int targetsKilled = 0;

    public Text timerText;
    public float timer = 0;
    public int mins = 0;

    public float bestTime = 0;

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
        if(script.selectedWeapon == 1)
        {
            if(Input.GetButton("Fire 1") && !gunFiring && ammo>0 && isReloading ==false)
            {
                gunFiring = true;
                ammo--;
                UpdateTexts();
                gunFiring = false;   
            }
        }else
        {
            if(Input.GetButtonDown("Fire 1") && !gunFiring && ammo > 0 && isReloading == false)
            {
                gunFiring = true;
                ammo -= 25;
                UpdateTexts();
                gunFiring = false;
            }
        }

        timer += Time.deltaTime;

        ReloadWeapon();

        UpdateTexts();

        
    }


    void UpdateTexts()
    {
        ammoText.text = ammo.ToString();
        targetsKilledText.text = targetsKilled.ToString() + " / 27";

        double conv = System.Math.Round(timer, 2);
        
        if (conv >= 60)
        {
            mins++;
            timer = 0;
        }

        timerText.text = mins + " : " + conv.ToString();
        
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

    public void killedTarget()
    {
        targetsKilled++;
    }


}

