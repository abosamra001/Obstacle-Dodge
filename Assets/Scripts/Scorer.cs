using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log($"You have hitten : {score} times");
    }
}
