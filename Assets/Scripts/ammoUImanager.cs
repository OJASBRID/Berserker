using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ammoUImanager : MonoBehaviour
{
    [SerializeField]
    public Text _ammoText1;
    public Text _ammoText2;
    public void UpdateAmmo1(int count1)
    {
        _ammoText1.text = count1 + "/";
    }
    public void UpdateAmmo2(int count2)
    {
        _ammoText2.text = count2+"";
    }
}
