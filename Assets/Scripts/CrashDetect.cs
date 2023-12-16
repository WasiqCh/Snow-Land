using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Ground" && !hasCrashed){
            hasCrashed = true;
            FindObjectOfType<TorqueControl>().disableCont();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("Delay_time",delay);
        }
    }
    void Delay_time(){
        SceneManager.LoadScene(0);
    }
}
