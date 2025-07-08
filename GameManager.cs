using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalEnemies;
    private int enemiesRemaining;

    public GameObject continueButton;
    public GameObject winPanel;

    void Start()
    {
        enemiesRemaining = totalEnemies;

        if (continueButton != null)
            continueButton.SetActive(false);

        if (winPanel != null)
            winPanel.SetActive(false);
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;

        if (enemiesRemaining <= 0)
        {
            Debug.Log("All enemies destroyed.");

            if (continueButton != null)
                continueButton.SetActive(true);

            if (winPanel != null)
                winPanel.SetActive(true);
        }
    }

    public void LoadNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit (only works in build)");
    }
}
