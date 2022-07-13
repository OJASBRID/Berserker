using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject[] enemies;
    public float time;
    private Vector3[] positions= new Vector3[11];
    public int EnemyCount;
    public bool Area1;
    public bool Area2;
    public bool Area3;
    
    // Start is called before the first frame update
    void Start()
    {
        positions[0] = new Vector3(53.9f, -1.48f, -58.9f);
        positions[1] = new Vector3(53.9f, -1.48f, -44.8f);
        positions[2] = new Vector3(29.8f, -1.48f, -34.8f);
        positions[3] = new Vector3(29.8f, -1.48f, -13.6f);
        positions[4] = new Vector3(2.8f, -1.48f, 13f);
        positions[5] = new Vector3(93f, -1.48f, -3.8f);
        positions[6] = new Vector3(52.3f, -1.48f, 9.3f);
        positions[7] = new Vector3(32.3f, -1.48f, 44.7f);
        positions[8] = new Vector3(-0.2f, -1.48f, -18.5f);
        positions[9] = new Vector3(26.5f, -1.48f, 19.3f);
        positions[10] = new Vector3(-29f, -1.48f, 19.3f);
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

    public void stitch1()
    {
        Area1 = !Area1;
        Area2 = !Area2;
    }

    public void stitch2()
    {
        Area3 = !Area3;
        Area2 = !Area2;
    }
}
