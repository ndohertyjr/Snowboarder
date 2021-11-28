using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] ParticleSystem finishEffect2;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            finishEffect2.Play();
            Invoke("ReloadScene", restartDelay);

        }
        

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
