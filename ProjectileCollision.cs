using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public GameObject explosionVFX;
    public AudioClip explosionSound;

    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Enemy"))
    {
        if (explosionVFX != null)
        {
            Instantiate(explosionVFX, other.transform.position, Quaternion.identity);
        }

        if (explosionSound != null)
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position, 7.0f); // boost the volume
        }

        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(100);
        }
        FindObjectOfType<GameManager>().EnemyDestroyed();
        Destroy(other.gameObject);     // Destroy enemy
        Destroy(gameObject);           // Destroy projectile
    }
}

    }

