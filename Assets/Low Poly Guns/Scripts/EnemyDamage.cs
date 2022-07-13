
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float health = 100f;
    public GameObject[] preFab;
    public Vector3 pos;

    public void Damage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
           
            Destroy(gameObject);
            pos.x = transform.position.x;

            pos.y = (float)(transform.position.y + 1);
            pos.z = transform.position.z;


            Instantiate(preFab[Random.Range(0,3)], pos, transform.rotation);
        }
    }

   
    

}
