
using UnityEngine;

public class ArBehaviour : MonoBehaviour
{
    public float damage = 35f;
    public float range = 100f;
    public float firerate = 15f;
    public Camera cam;
    public bool firetype;
    public ParticleSystem flash;

    private float Delay= 0f;
    //public GameObject FleshImpactEffect;
    // public GameObject ElseImpactEffect;
    void Update()
    {
        if (firetype)
        { 
        if (Input.GetButton("Fire1") && Time.time >= Delay)
        {
            Delay = Time.time + 1f / firerate;
            Shoot();
        }
        }

        else
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= Delay)
            {
                Delay = Time.time + 1f / firerate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        flash.Play();
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range))
        {
            EnemyDamage target = hit.transform.GetComponent<EnemyDamage>();
            
            {
                 if(target != null)
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
