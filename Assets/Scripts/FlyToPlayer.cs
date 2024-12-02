using UnityEngine;

public class FlyToPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed = 10f;
    [SerializeField] Transform player;
    Vector3 myPosition;
    void Start()
    {
        
        myPosition =player.transform.position;
    }

    void Update()
    {
        transform.position= Vector3.MoveTowards(transform.position,myPosition, Time.deltaTime * flySpeed * 8);
        if(transform.position == myPosition)
        {
            Destroy(gameObject);
        }
    }
}
