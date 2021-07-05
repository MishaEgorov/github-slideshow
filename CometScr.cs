using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometScr : MonoBehaviour
{
    public int dmg;
    public Transform centr;
    public GameObject Ind;
    void Start()
    {
        Ind = Instantiate(Ind);
        Ind.GetComponent<Indicator>().TrackedObj=gameObject;
        centr = GameObject.FindGameObjectWithTag("Planet").transform;
    }
    void Update()
    {
        transform.position =  Vector2.Lerp(transform.position, centr.position,0.001f);    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Planet")
        {
            if(FindObjectOfType<InfoPlanet>().hpPlanet / 10<0)
            {
                FindObjectOfType<InfoPlanet>().hpPlanet = 0;
                Destroy(gameObject);
            }
            else
            {
                dmg = FindObjectOfType<InfoPlanet>().hpPlanet / 10;
                FindObjectOfType<InfoPlanet>().hpPlanet -= dmg;
                Destroy(gameObject);
            }
           
        }
        if (collision.gameObject.tag == "Protection")
        {          
            Destroy(gameObject);
        }

    }
    private void OnBecameVisible()
    {
        Destroy(Ind);
    }
}
