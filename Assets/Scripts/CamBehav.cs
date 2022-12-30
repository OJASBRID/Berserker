using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehav : MonoBehaviour
{
    public Transform Cameraposition;

    private void Update()
    {
        transform.position= Cameraposition.position;
    }
}
