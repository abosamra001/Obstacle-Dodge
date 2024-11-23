using UnityEngine;

public class DropdownThings : MonoBehaviour
{
    [SerializeField] float dropAfter = 3;

    private void Update()
    {

        //Debug.Log("the game was started since "+Time.time);
        if (Time.time > dropAfter)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        

            
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GameObject.Destroy(gameObject);
    }


}
