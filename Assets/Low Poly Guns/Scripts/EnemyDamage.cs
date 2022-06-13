
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float health = 100f;
    public void Damage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);
            
        }
    }

}
