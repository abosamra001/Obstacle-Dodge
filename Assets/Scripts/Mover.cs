
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        /*//print("the update method has been called");// called over and over
        //getAxis returns(-1,1) left and right
        //the Input class is old noadays there is a newer one Input system package
        // for now we are using the legacy one but in the future we will learn the newer one keep moving for now;*/

        MovePlayer();
        
    }
    void MovePlayer()
    {
 
        float xValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;// up and down
        float yValue = 0;
        float zValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;// left and right

        //public property refers to this game object
        transform.Translate(xValue, yValue, -zValue);
    }
    
}
