using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityScr : MonoBehaviour
{
    public GameObject FirstAb;
    public bool FACheck;
    public int startClick;
    public float TimeFAb;
    public float TimeKDF;
    public bool StartBool;
    public void Start()
    {
        StartBool = true;
        startClick = 1;
        TimeFAb = FindObjectOfType<Load>().TimeFAbSave;
        if(PlayerPrefs.GetFloat("KDF") - FindObjectOfType<Save>().secondPassef>0)
        {
            TimeKDF = PlayerPrefs.GetFloat("KDF") - FindObjectOfType<Save>().secondPassef;
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
        if(FACheck&&TimeKDF==0f)
        {
            TimeFAb = FindObjectOfType<Load>().TimeFAbSave;
            FirstAb.GetComponent<Image>().color = Color.green;
            StartCoroutine(FirtstAbStart());
        }    
    }
    public void Update()
    {
    
        if (!FACheck && StartBool)
        {
            StartCoroutine(FirtstAbWait());
            TimeFAb = FindObjectOfType<Load>().TimeFAbSave;
           
        }
        if(startClick==1 && FACheck && TimeKDF == 0f)
        {
            FirstAb.GetComponent<Image>().color = Color.white;
        }
       
    }
    private IEnumerator FirtstAbStart()
    {
        PlayerPrefs.SetFloat("KDF", 15f);
        TimeKDF = PlayerPrefs.GetFloat("KDF");
        startClick = 3;    
        yield return new WaitForSeconds(TimeFAb);
        FACheck = false;
        FirstAb.GetComponent<Image>().color = Color.red;
        startClick = 1;
       
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
