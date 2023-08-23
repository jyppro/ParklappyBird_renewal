using UnityEngine;

public class Scoreup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) { Score.score++; }
}
