using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float glitchChance = 0.05f;
    public float teleportRange = 3f;

    void Update()
    {
        if (target == null) return;

        if (Random.value < glitchChance * Time.deltaTime)
        {
            // Glitch: Random jump
            Vector3 glitchOffset = new Vector3(
                Random.Range(-teleportRange, teleportRange),
                0,
                Random.Range(-teleportRange, teleportRange)
            );

            transform.position += glitchOffset;
        }
        else
        {
            // Normal movement
            Vector3 dir = (target.position - transform.position).normalized;
            transform.position += dir * speed * Time.deltaTime;
        }
    }
}
