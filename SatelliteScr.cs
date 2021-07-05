using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteScr : MonoBehaviour
{
    public Transform centr;

    public float  radius=2f;
    public float angularSpeed;
    float posX, posY,angle=0f;
    private void Awake()
    {
        angularSpeed = FindObjectOfType<PrestigeScr>().speed;
        centr = GameObject.FindGameObjectWithTag("Planet").transform;  
    }
    void Update()
    {
        posX = centr.position.x + Mathf.Cos(angle) * radius;
        posY = centr.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posX, posY);
        angle += Time.deltaTime *angularSpeed;
        if (angle >= 360)
        {
            angle = 0;
        }
    }
}
