using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayReloadScene = 0.2f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delayReloadScene);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
