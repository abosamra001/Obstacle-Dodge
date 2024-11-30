using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Hit"))score++;
        Debug.Log($"You have hitten : {score} times");
    }
}
