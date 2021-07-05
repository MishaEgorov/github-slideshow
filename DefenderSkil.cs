using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderSkil : MonoBehaviour
{
    public GameObject FirstAb;
    public GameObject Def;
    public bool FACheck;
    public float TimeFAb;
    public float TimeKDF;
    public bool isDEf;
    public bool DEFBoll;
    public void Start()
    {
        DEFBoll = true;
        TimeFAb = FindObjectOfType<Load>().TimeDEF;
        if (PlayerPrefs.GetFloat("KDDEf") - FindObjectOfType<Save>().secondPassef > 0)
        {
            TimeKDF = PlayerPrefs.GetFloat("KDDEf") - FindObjectOfType<Save>().secondPassef;
            StartCoroutine(FirtstAbWait());
        }
        else
        {
            TimeKDF = 0f;
        }
        if (TimeKDF > 0)
        {
            FirstAb.GetComponent<Image>().color = Color.red;
        }
    }
    public void FirstAbRes()
    {
        if (FACheck && TimeKDF == 0f)
        {
            TimeFAb = FindObjectOfType<Load>().TimeDEF;
            FirstAb.GetComponent<Image>().color = Color.green;
            StartCoroutine(FirtstAbStart());
            isDEf = true;
            Def.SetActive(true);
        }

    }
    public void Update()
    {
       
        if (!FACheck && DEFBoll)
        {
            StartCoroutine(FirtstAbWait());
            TimeFAb = FindObjectOfType<Load>().TimeDEF;
        }
        if (FACheck && TimeKDF == 0f&&!isDEf)
        {
            FirstAb.GetComponent<Image>().color = Color.white;
        }
    }
    private IEnumerator FirtstAbStart()
    {
        PlayerPrefs.SetFloat("KDDEf", 15f);
        TimeKDF = PlayerPrefs.GetFloat("KDDEf");
        yield return new WaitForSeconds(TimeFAb);
        FACheck = false;
        isDEf = false;
        FirstAb.GetComponent<Image>().color = Color.red;
    }
    private IEnumerator FirtstAbWait()
    {
        DEFBoll = false;
        Def.SetActive(false);      
        yield return new WaitForSeconds(TimeKDF);
        TimeKDF = 0f;
        FACheck = true;
        DEFBoll = true;
    }

}
