using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20f;
    // Start is called before the first frame update

    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Vertical");
        float z=Input.GetAxis("Horizontal");
        float y= 
        if(z>0){
            rb.AddForce(Vector3.right *speed);
        }else if(z<0){
            rb.AddForce(Vector3.left *speed);
        }
        if(x>0){
            rb.AddForce(Vector3.forward *speed);
        }else if(x<0){
            rb.AddForce(Vector3.back *speed);
        }
        transform.eulerAngles = new Vector3(-70f, 0, -z*20f);
    }
}
