using UnityEngine;

public class DropdownThings : MonoBehaviour
{
    [SerializeField] float dropAfter = 3;
    MeshRenderer myMesh;
    Rigidbody myRigid;

    private void Start()
    {
        myMesh=GetComponent<MeshRenderer>();
        myRigid=GetComponent<Rigidbody>();

        myMesh.enabled=false;
        myRigid.useGravity=false;
    }
    private void Update()
    {
        if(Time.time> dropAfter)
        {
            myMesh.enabled = true;
            myRigid.useGravity = true;
        }

    }
    


}