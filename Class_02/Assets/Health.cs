using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float health = 12f;
    
    void Start()
    {
        
    }

    public void Damage(float damage){
        health -=damage;
        Debug.Log("Health : " + health);
        if(health<=0){
            Destroy(gameObject);
        }
    }
    
}
