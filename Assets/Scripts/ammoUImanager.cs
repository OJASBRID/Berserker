
using UnityEngine;
using UnityEngine.UI;


public class ammoUImanager : MonoBehaviour
{
    [SerializeField]
    public Text _ammoText1;
    public Text _ammoText2;
    public ArBehaviour arBehaviour1;
    public ArBehaviour arBehaviour2;
    public WeaponSwitch weaponSwitch;


    void Update()
    {
        if (weaponSwitch.weaponNo == 0)
        {
            _ammoText1.text = arBehaviour1.currentAmmo + "/";
            _ammoText2.text = arBehaviour1.totalammo + "";
           
        }

        else if(weaponSwitch.weaponNo == 1)
        {
            _ammoText1.text = arBehaviour2.currentAmmo + "/";
            _ammoText2.text = arBehaviour2.totalammo + "";
        }
    }
}
