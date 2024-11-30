using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpinSpeed=0;
    [SerializeField] float ySpinSpeed=1;
    [SerializeField] float zSpinSpeed=0;
    Rigidbody myRigid;
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        myRigid.useGravity = false;
        myRigid.isKinematic = true;
    }

    
    void Update()
    {
        
        transform.Rotate(xSpinSpeed, ySpinSpeed, zSpinSpeed);
        
    }
}
