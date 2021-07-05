using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScr : MonoBehaviour
{
    public GameObject Comet;
    public float time;
    public bool isSpawm;
    void Start()
    {
        isSpawm = false;
        time = Random.Range(100, 360);
    }
    void Update()
    {
        if(time<=0&&!isSpawm)
        {
            StartCoroutine(SpawmComet());         
        }
        else
        {
            time-=Time.deltaTime;
        }
        
    }
    IEnumerator SpawmComet()
    {
        isSpawm = true;
        Instantiate(Comet, new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)), Quaternion.identity);
        yield return new WaitForSeconds(1f);
        time = Random.Range(100, 360);
        isSpawm = false;
    }
}
