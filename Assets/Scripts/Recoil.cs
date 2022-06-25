
using UnityEngine;

public class Recoil : MonoBehaviour
{

    private Vector3 currentRotation;
    private Vector3 targetRotation;

    [SerializeField] private float recoilX;
    [SerializeField] private float recoilX1;
    [SerializeField] private float recoilY;
    [SerializeField] private float recoilY1;
    [SerializeField] private float recoilZ;
    [SerializeField] private float recoilZ1;

    [SerializeField] private float snapiness;
    [SerializeField] private float returnspeed;

    


    void Start() {
       

    }


    void Update()
    {
        targetRotation = Vector3.Lerp(targetRotation, Vector3.zero, returnspeed * Time.deltaTime);
        currentRotation = Vector3.Slerp(currentRotation, targetRotation, snapiness * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    public void RecoilFire1()
    { 
        targetRotation += new Vector3(recoilX, Random.Range(-recoilY, recoilY), Random.Range(-recoilZ, recoilZ));
        
    }

    public void RecoilFire2()
    {
        targetRotation += new Vector3(recoilX1, Random.Range(-recoilY1, recoilY1), Random.Range(-recoilZ1, recoilZ1));

    }
}
