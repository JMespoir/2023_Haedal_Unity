using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    Image a;
    Image b;
    Image c;
    Image d;
    // Start is called before the first frame update
    void Start()
    {
        a= up.GetComponent<Image>();
        b= down.GetComponent<Image>();
        c= left.GetComponent<Image>();
        d= right.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            a.color = Color.red;
        }
        else{
            a.color = Color.white;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            b.color = Color.red;
        }
        else{
            b.color = Color.white;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            c.color = Color.red;
        }
        else{
            c.color = Color.white;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            d.color = Color.red;
        }
        else{
            d.color = Color.white;
        }
    }
}
