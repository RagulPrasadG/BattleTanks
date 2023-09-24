using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] ParticleSystem burstEffect;
 
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Tank"))
        {
            burstEffect.Play();
            Destroy(this.gameObject,0.5f);
        }
    }




}
