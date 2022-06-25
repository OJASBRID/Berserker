using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject[] enemies;
    public float time;
    private Vector3[] positions= new Vector3[11];
    public int EnemyCount;
    
    // Start is called before the first frame update
    void Start()
    {
        positions[0] = new Vector3(23.00f, -1.48f, -69.9f);
        positions[1] = new Vector3(76.1f, -1.48f, 69.4f);
        positions[2] = new Vector3(104.4f, -1.48f, 44.3f);
        positions[3] = new Vector3(99.2f, -1.48f, -48.1f);
        positions[4] = new Vector3(23.00f, -1.48f, 63.4f);
        positions[5] = new Vector3(99.2f, -1.48f, 85.5f);
        positions[6] = new Vector3(-21.3f, -1.48f, -20.6f);
        positions[7] = new Vector3(21.3f, -1.48f, -75.0f);
        positions[8] = new Vector3(137.6f, -1.48f, 85.5f);
        positions[9] = new Vector3(137.6f, -1.48f, -97.6f);
        positions[10] = new Vector3(-52.2f, -1.48f, -97.6f);
        if (EnemyCount <= 20)
        {
            StartCoroutine(EnemyDrop());
        }
    }

    IEnumerator EnemyDrop()
    {
        time = 5f;
        while(EnemyCount<=40)
        {
            
            for(int i=0;i<10;i++)
            {
                Instantiate(enemies[Random.Range(0, 2)], positions[Random.Range(0, 10)], Quaternion.identity);
                yield return new WaitForSeconds(0f);
                
                EnemyCount += 1;
            }

            time -= 0.3f;


        }
    }

}
