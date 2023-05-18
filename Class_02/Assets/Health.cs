using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float health = 12f;
    public bool isDelay;
    SpriteRenderer ObjColor;

    void Start()
    {
        ObjColor = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Damage(float damage){
        health -=damage;
        StartCoroutine(Red());
        if(health<=0){
            Destroy(gameObject);
        }
    }
    
    IEnumerator Red(){
        ObjColor.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        ObjColor.color = Color.white;
        isDelay=false;
    }
}

