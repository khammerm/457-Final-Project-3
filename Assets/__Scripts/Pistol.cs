using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float damage = 5f;
    public float range = 70f;
    public float impactForce = 20f;
    public float fireRate = 10f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    private float nextTimeToFire = 0f;

    void Update()
    {
        // basic input reading
        if(Input.GetButtonDown("Fire 1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        // playing our muzzleflash particle system
        muzzleFlash.Play();
        RaycastHit hit;
        // raycasting for bullets
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            // dmg for targets (future enemies)
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            // instantiate our impact system with Quaternian rotation, would prob work better with diff particle system.
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
        
    }
}
