using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snow_effect;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            snow_effect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        snow_effect.Stop();
    }
}
