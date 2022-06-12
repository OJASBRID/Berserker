
using UnityEngine;

public class ArBehaviour : MonoBehaviour
{
    public float damage = 35f;
    public float range = 100f;
    public Camera cam;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range))
        {
            EnemyDamage target = hit.transform.GetComponent<EnemyDamage>();
            
            {
                 if(target != null)
                {
                    target.Damage(damage);
                }
            }
        }
    }
    
}
