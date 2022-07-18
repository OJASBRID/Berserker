
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public bool active;
    public int weaponNo = 0;
    
    void Start()
    {
        SelectWeapon();
        active = false;
    }


    void Update()
    {
        int previousSelectedWeapon = weaponNo;

        if (!active)
        { 
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (weaponNo >= transform.childCount - 1)
                weaponNo = 0;
            else
                weaponNo++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (weaponNo <= transform.childCount - 1)
                weaponNo = 0;
            else
                weaponNo--;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponNo = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            weaponNo = 0;
        }

        if (previousSelectedWeapon != weaponNo)
        {
            SelectWeapon();

        }
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            {
                if (i == weaponNo)
                    weapon.gameObject.SetActive(true);
                else
                    weapon.gameObject.SetActive(false);
                i++;
            }
        }
    }
}
