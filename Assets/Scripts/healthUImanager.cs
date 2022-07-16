using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthUImanager : MonoBehaviour
{
    [SerializeField]
    public Text _healthText;
    public void UpdateHealth(float health)
    {
        _healthText.text = "Health: " + health;
    }
}
