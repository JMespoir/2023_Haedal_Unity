using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    private int damage=3;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.GetComponent<Health>() != null){
            Health health = collision.GetComponent<Health>();
            health.Damage(damage);

            collision.GetComponent<Health>().Damage(damage);
        }
    }
    
    
}