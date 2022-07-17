
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float health = 100f;
    public GameObject[] preFab;
    private Vector3 pos;
    public Score score;

    public void Damage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            if(gameObject.name =="Zombie1")
            {
                score.Shoot1();
            }
            else if(gameObject.name == "Zombie2")
            {
                score.Shoot2();
            }
            Destroy(gameObject);
            pos.x = transform.position.x;

            pos.y = (float)(transform.position.y + 1);
            pos.z = transform.position.z;


            Instantiate(preFab[Random.Range(0,3)], pos, transform.rotation);
        }
    }

   
    

}
