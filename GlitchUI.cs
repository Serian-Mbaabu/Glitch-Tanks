using System.Collections;
using UnityEngine;
using TMPro;

public class GlitchUI : MonoBehaviour
{
    public GameObject errorText;

    void Start()
    {
        InvokeRepeating("Flicker", 3f, Random.Range(6f, 10f));
    }

    void Flicker()
    {
        StartCoroutine(FlashError());
    }

    IEnumerator FlashError()
    {
        errorText.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        errorText.SetActive(false);
    }
}
