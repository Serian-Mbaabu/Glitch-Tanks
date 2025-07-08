using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    void Start()
    {
        float lifetime = GetComponent<ParticleSystem>().main.duration;
        Destroy(gameObject, lifetime);
    }
}
