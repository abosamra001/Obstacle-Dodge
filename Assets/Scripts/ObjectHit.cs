using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color initColor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null) return;
        initColor= GetComponent<MeshRenderer>().material.color;

        GetComponent<MeshRenderer>().material.color = Color.red;

        //Debug.Log("something hit me ");

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision == null) return;
        GetComponent<MeshRenderer>().material.color = initColor;
    }
}
