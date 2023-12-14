using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Ground"){
            crashEffect.Play();
            Invoke("Delay_time",delay);
        }
    }
    void Delay_time(){
        SceneManager.LoadScene(0);
    }
}
