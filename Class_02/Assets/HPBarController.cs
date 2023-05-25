using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{
    public float MAX_HEALTH = 12f;
    public float NOW_HEALTH = 12f;
    public GameObject monster;
    public GameObject HPBar;
    Image a; 

    void Start()
    {
        a= HPBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        NOW_HEALTH = monster.GetComponent<Health>().health;
        a.fillAmount = NOW_HEALTH/MAX_HEALTH;
    }
}
