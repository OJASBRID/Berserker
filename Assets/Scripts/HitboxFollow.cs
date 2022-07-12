using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFollow : MonoBehaviour
{
    public Transform game;
    
    void Start()
    {
        gameObject.transform.position = game.transform.position;
    }

    
    void Update()
    {
        gameObject.transform.position = game.transform.position;
    }
}
