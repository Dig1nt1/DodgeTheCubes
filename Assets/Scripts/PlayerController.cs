using UnityEngine;
using UnityEngine.UI; // Add this
using TMPro;          // Add this if using TextMeshPro
using UnityEngine.SceneManagement; // For restart

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject gameOverUI;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
