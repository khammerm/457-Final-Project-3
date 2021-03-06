using UnityEngine;
using static WeaponSwitching;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 15f;
    public bool canUse = true;

    public WeaponSwitching Script;
    public LineRenderer bulletTrail;
    public Transform shootPoint;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AmmoDisplay ammo;

    public AudioSource gunSound;
    
    private float nextTimeToFire = 0f;

    void Update()
    {
        
        if(ammo.isReloading== false && canUse && Script.selectedWeapon == 1)
        {
            // basic input reading
            if (Input.GetButton("Fire 1") && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }else
        {
            // basic input reading
            if (Input.GetButtonDown("Fire 1") && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
        
    }

    public void Shoot()
    {

        if(canUse)
        {
            if(gunSound != null)
                gunSound.Play();  // shooting sound

            muzzleFlash.Play();  // muzzle flash particles
            RaycastHit hit;
            // raycasting for bullets
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                // dmg for targets (future enemies)
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
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

                SpawnBulletTrail(hit.point);
            }
        }
        
    }
    public void  SpawnBulletTrail(Vector3 hitPoint)
    {
        if (ammo.isReloading == false)
        {
            GameObject bulletTrailEffect = Instantiate(bulletTrail.gameObject, shootPoint.transform.forward, Quaternion.identity);

            LineRenderer lineR = bulletTrailEffect.GetComponent<LineRenderer>();

            lineR.SetPosition(0, shootPoint.position);
            lineR.SetPosition(1, hitPoint);

            Destroy(bulletTrailEffect, .1f);

        }
        
    }
}
