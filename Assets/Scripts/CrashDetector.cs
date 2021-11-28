using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    CircleCollider2D playerHead;
    [SerializeField] float restartDelay = 1f;

    [SerializeField] ParticleSystem crashEffect;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Bonk!");
            crashEffect.Play();
            Invoke("ReloadScene", restartDelay);
            
        }
        
    }

    void ReloadScene() 
    {
        SceneManager.LoadScene(0);
    }
}
