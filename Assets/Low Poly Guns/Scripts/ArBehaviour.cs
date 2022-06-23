
using UnityEngine;
using System.Collections;

public class ArBehaviour : MonoBehaviour
{
    public float damage = 35f;
    public float range = 100f;
    public float firerate = 15f;
    public Camera cam;
    public bool firetype;
    public ParticleSystem flash;
    public int maxAmmo = 10;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;
    private float Delay = 0f;
    public Animator animator;
    public int totalammo;

    public Recoil recoilScript;
    //public GameObject FleshImpactEffect;
    // public GameObject ElseImpactEffect;

    private void Start()
    {

        currentAmmo = maxAmmo;

    }

    private void OnEnable()
    {
        isReloading = false;
        animator.SetBool("Reloading", false);
    }
    void Update()
    {
        if (isReloading)
            return;
        if ((currentAmmo <= 0 || Input.GetKeyDown(KeyCode.R)) && totalammo != 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (firetype)
        {
            if (Input.GetButton("Fire1") && Time.time >= Delay)
            {
                Delay = Time.time + 1f / firerate;
                Shoot(firetype);
            }
        }

        else
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= Delay)
            {
                Delay = Time.time + 1f / firerate;
                Shoot(firetype);
            }
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        animator.SetBool("Reloading", true);
        yield return new WaitForSeconds(reloadTime - .25f);
        animator.SetBool("Reloading", false);
        yield return new WaitForSeconds(.25f);

        if (totalammo < maxAmmo && totalammo > 0)
        {
            currentAmmo = totalammo;
            totalammo = 0;

        }
        else
        { 
        totalammo = totalammo - maxAmmo + currentAmmo;
        currentAmmo = maxAmmo;
        }

        
        
        isReloading = false;

    }
    void Shoot(bool value)
    { if (!(currentAmmo + totalammo <= 0))
        { 
        currentAmmo--;
        if (value)
        {
            recoilScript.RecoilFire1();
        }

        else
        {
            recoilScript.RecoilFire2();
        }
        flash.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            EnemyDamage target = hit.transform.GetComponent<EnemyDamage>();

            {
                if (target != null)
                {
                    target.Damage(damage);
                    // GameObject impact1 = Instantiate(FleshImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    //Destroy(impact1, 1.5f);
                }

                //GameObject impact2 = Instantiate(ElseImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                //Destroy(impact2, 1.5f);
            }
        }
    }
}
}
