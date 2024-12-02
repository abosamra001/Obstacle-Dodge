using UnityEngine;

public class TriggerFlyingObjects : MonoBehaviour
{

    [SerializeField] GameObject flyingObject;
    private void Awake()
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
