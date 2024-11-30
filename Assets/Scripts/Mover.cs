
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 20.0f;

    void Update()
    {
        MovePlayer();   
    }
    void MovePlayer()
    {
 
        float xValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;// up and down
        float yValue = 0;
        float zValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;// left and right

        transform.Translate(xValue, yValue, -zValue);
    }
    
}
