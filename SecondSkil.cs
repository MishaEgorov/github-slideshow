using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSkil : MonoBehaviour
{
    public GameObject FirstAb;
    public bool FACheck;
    public int dobX;
    public float TimeFAb;
    public float TimeKDF;
    public bool StartBool;
    public void Start()
    {
       
        StartBool = true;
        dobX = 1;
        TimeFAb = FindObjectOfType<Load>().TimeSAbSave;
        if (PlayerPrefs.GetFloat("KDS") - FindObjectOfType<Save>().secondPassef > 0)
        {
            TimeKDF = PlayerPrefs.GetFloat("KDS") - FindObjectOfType<Save>().secondPassef;
            StartCoroutine(FirtstAbWait());
        }
        else
        {
            TimeKDF = 0f;
        }
        if (TimeKDF>0)
        {
            FirstAb.GetComponent<Image>().color = Color.red;
        }
    }
    public void FirstAbRes()
    {
        if (FACheck&&TimeKDF==0f)
        {
            TimeFAb = FindObjectOfType<Load>().TimeSAbSave;
            FirstAb.GetComponent<Image>().color = Color.green;
            StartCoroutine(FirtstAbStart());
        }
    }
    public void Update()
    {

        if (!FACheck && StartBool)
        {
            StartCoroutine(FirtstAbWait());
            TimeFAb = FindObjectOfType<Load>().TimeSAbSave;

        }
        if (dobX == 1 && FACheck && TimeKDF == 0f)
        {
            FirstAb.GetComponent<Image>().color = Color.white;
        }

    }
    private IEnumerator FirtstAbStart()
    {
        PlayerPrefs.SetFloat("KDS", 15f);
        TimeKDF = PlayerPrefs.GetFloat("KDS");      
        dobX = 2;
        yield return new WaitForSeconds(TimeFAb);
        FACheck = false;
        FirstAb.GetComponent<Image>().color = Color.red;
        dobX = 1;

    }
    private IEnumerator FirtstAbWait()
    {
        StartBool = false;
        yield return new WaitForSeconds(TimeKDF);
        TimeKDF = 0f;
        FACheck = true;
        StartBool = true;

    }
}
