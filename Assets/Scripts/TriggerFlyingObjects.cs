using UnityEngine;

public class TriggerFlyingObjects : MonoBehaviour
{

    [SerializeField] GameObject flyingObject;
    private void Start()
    {
        flyingObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flyingObject.SetActive(true);
        }
    }

}
