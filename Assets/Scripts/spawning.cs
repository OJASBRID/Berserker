using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject[] enemies;
    private Vector3[] positions = new Vector3[12];
    public int EnemyCount;
    public bool Area1;
    public bool Area2;
    public bool Area3;

    // Start is called before the first frame update
    void Start()
    {
        positions[0] = new Vector3(10.5f, -1.7f, -57.5f);
        positions[1] = new Vector3(-23.1f, -1.7f, -33f);
        positions[2] = new Vector3(-29.8f, -1.7f, 25.6f);
        positions[3] = new Vector3(68f, -1.7f, -51.1f);
        positions[4] = new Vector3(-0.4f, -1.7f, -12.9f);
        positions[5] = new Vector3(29.8f, -1.7f, -33.9f);
        positions[6] = new Vector3(-17.5f, -1.7f, 45.7f);
        positions[7] = new Vector3(93.9f, -1.7f, -13.8f);
        positions[8] = new Vector3(79.2f, -1.7f, -21.8f);
        positions[9] = new Vector3(52.2f, -1.7f, -1.3f);
        positions[10] = new Vector3(76.7f, -1.7f, 17.9f);
        positions[11] = new Vector3(63.5f, -1.7f, 39.1f);
        if (EnemyCount <= 20)
        {
            StartCoroutine(EnemyDrop());
        }
    }

    IEnumerator EnemyDrop()
    {

        while (EnemyCount <= 60)
        {
            int a = 0, b = 0;
            if (Area1)
            {
                a = 0; b = 2;
            }
            if (Area2)
            {
                a = 2; b = 7;
            }
            if (Area3)
            {
                a = 7; b = 12;
            }

            Instantiate(enemies[Random.Range(0, 2)], positions[Random.Range(a, b)], Quaternion.identity);
            yield return new WaitForSeconds(3f);

            EnemyCount += 1;




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

