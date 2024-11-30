using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color initColor;

    private void OnCollisionEnter(Collision other)
    {
        if (other == null) return;
        if (other.gameObject.CompareTag("Player"))
        {

            initColor = GetComponent<MeshRenderer>().material.color;

            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

        }

        //Debug.Log("something hit me ");

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision == null) return;
        if(collision.gameObject.CompareTag("Player"))
            GetComponent<MeshRenderer>().material.color = initColor;
    }
}
