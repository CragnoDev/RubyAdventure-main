using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeathCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem HealParticles;
    public ParticleSystem HealParticlesInstance;


    void OnTriggerEnter2D(Collider2D other)
{
   PlayerController controller = other.GetComponent<PlayerController>();


   if (controller != null && controller.currentHealth < controller.maxHealth)
   {
       controller.ChangeHealth(1);
       Destroy(gameObject);
            SpawnHealParticles();
       controller.PlaySound(collectedClip);
       
   }
}

    public void SpawnHealParticles()
    {
        HealParticlesInstance = Instantiate(HealParticles, transform.position, Quaternion.identity);
    }
}