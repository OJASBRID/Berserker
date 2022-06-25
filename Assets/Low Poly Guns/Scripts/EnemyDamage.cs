
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float health = 100f;
    public GameObject gameObjects;
    public void Damage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);
            Instantiate(gameObjects, gameObject.transform);
        }
    }

}
