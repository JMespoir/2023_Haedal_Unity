using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public GameObject a;
    public float b;
    void Start()
    {
        
    }

    
    void Update()
    {

        Vector3 P= a.transform.position ;
        P.z -= b;
        P.y += 1f;
        transform.position =P;
    }
}
