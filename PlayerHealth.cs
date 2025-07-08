using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;

    private PlayerController playerController;

    void Start()
    {
        currentLives = maxLives;
        playerController = GetComponent<PlayerController>();
        UpdateLivesUI();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentLives--;
            UpdateLivesUI();

            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + currentLives;
        }
    }

    void GameOver()
    {
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);

        if (playerController != null)
            playerController.DisableMovement();
    }
}
