using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 12f;
    public bool isDelay;
    public GameObject HPBAR_UI;
    SpriteRenderer ObjColor;

    void Start()
    {

        ObjColor = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Damage(float damage){
        health -=damage;
        HPBAR_UI.SetActive(true);
        StartCoroutine(Red());
        if(health<=0){
            Destroy(gameObject);
            HPBAR_UI.SetActive(false);
        }
    }
    
    IEnumerator Red(){
        ObjColor.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        ObjColor.color = Color.white;
        isDelay=false;
    }
}

