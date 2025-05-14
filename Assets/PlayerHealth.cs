using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health; 
    public int maxHealth = 10;
    Vector2 startPos;
    Collider2D collision;
    public TMP_Text healthText;

    private void Start(){
        startPos = transform.position;
        health = maxHealth;
        healthText.text = "Health: " + health;
    }
     
    public void TakeDamage(int amount){
        health -= amount;
        healthText.text = "Health: " + health;
            if(health <= 0){
                Die();
            }
        }
    public void Die()
    {
        StartCoroutine(Respawn(0.5f));
        health = 0;
    }
    
    IEnumerator Respawn(float duration){
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        health = 10;
    }
    }
