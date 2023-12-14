using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem finish_effect;
    void OnTriggerEnter2D(Collider2D other)
    {
        finish_effect.Play();
        Invoke("Delay_time",delay);
    }
    void Delay_time(){
        SceneManager.LoadScene(0);
    }
}
