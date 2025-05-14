using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 3;
    public PlayerHealth playHealth;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playHealth = other.gameObject.GetComponent<PlayerHealth>();
            playHealth.TakeDamage(damageAmount);
        }
    }
            
}
