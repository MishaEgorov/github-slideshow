using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrestigeScr : MonoBehaviour
{
    public GameObject Satellite;
    public float speed;
    void Start()
    {
        speed = 0.5f;
        for (int i = 1; i <= FindObjectOfType<Load>().PrestigeSave; i++)
        {
            speed += 0.2f;
            Instantiate(Satellite);     
        }
    }
}
