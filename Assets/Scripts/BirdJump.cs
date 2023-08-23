using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,3)
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.BestScore) { Score.BestScore = Score.score; }
        SceneManager.LoadScene("GameOverScene");
    }
}
