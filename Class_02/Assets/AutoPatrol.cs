using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPatrol : MonoBehaviour
{   public Animator animator;
    public float moveSpeed = 1f;
    public float moveTimer = 0f;
    public float moveTime = 10f;
    Vector2 rdv;
    public float maxLength = 2f;
    public bool isCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rdv = new Vector2(transform.position.x + Random.Range(-maxLength,maxLength), transform.position.y + Random.Range(-maxLength,maxLength));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        moveTimer += Time.deltaTime;
        if(moveTimer>moveTime){
            transform.position = Vector2.MoveTowards(transform.position,rdv,moveSpeed * Time.deltaTime);
            animator.SetBool("isMoving", true);

            if(Vector2.Distance(transform.position,rdv)<maxLength/10f){
                rdv = new Vector2(transform.position.x + Random.Range(-maxLength,maxLength), transform.position.y + Random.Range(-maxLength,maxLength));
                moveTimer = 0f;
                animator.SetBool("isMoving",false);
            }
        }
    }
    
}
