using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pressKeySound;
    private bool hasPressedKey = false;

    void Update()
    {
        if (!hasPressedKey && Input.anyKeyDown)
        {
            hasPressedKey = true;

            if (audioSource != null && pressKeySound != null)
            {
                audioSource.PlayOneShot(pressKeySound);
            }

            Invoke("LoadScene", 0.5f);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Level1_Tutorial");
    }
}
