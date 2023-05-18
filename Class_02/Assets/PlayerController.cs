using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject AttackArea;
    public GameObject ConversationArea;
    public float speed;
    Rigidbody2D rgbd;
    float h;
    float v;
    public SpriteRenderer spr;
    public Animator ani;
    private float curTime;
    public float coolTime = 0.5f;
    
    void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        rgbd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        
    }

    
    void Update()
    {

        h=Input.GetAxisRaw("Horizontal");
        v=Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.T)){
            ConversationArea.SetActive(true);
        }
        else{
            ConversationArea.SetActive(false);
        }
        if(Input.GetKey(KeyCode.Space)){
            
            if(curTime<=0){
                ani.SetBool("IsAttack",true);
                AttackArea.SetActive(true);
                curTime =coolTime;
            }
        }else{
            ani.SetBool("IsAttack",false);
            AttackArea.SetActive(false);
            curTime -= Time.deltaTime;
        }


        if(h<0){
            spr.flipX = false;
            AttackArea.transform.localScale = new Vector3(1,1,1);
            
        }
        if(h>0){
            spr.flipX = true;
            AttackArea.transform.localScale = new Vector3(-1,1,1);
        }
        if(h!=0 || v!=0){
            ani.SetBool("IsWalking",true);
        }
        else{
            ani.SetBool("IsWalking",false);
        }
    }

    void FixedUpdate(){
        rgbd.velocity = new Vector2(h,v)*speed;
        
    }
}
