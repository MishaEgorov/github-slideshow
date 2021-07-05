using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarfallSkil : MonoBehaviour
{
    public GameObject FirstAb;
    public bool FACheck;
    public float TimeFAb;
    public float TimeKDF;
    public bool StartBool;
    public int StarMoney;
    public GameObject[] Star;
    public bool nach;
    public void Start()
    {
       
        StartBool = true;
        nach = true;
        TimeFAb = FindObjectOfType<Load>().TimeTAbSave;
        if (PlayerPrefs.GetFloat("KDStar") - FindObjectOfType<Save>().secondPassef > 0)
        {
            TimeKDF = PlayerPrefs.GetFloat("KDStar") - FindObjectOfType<Save>().secondPassef;
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
            nach = false;
            FirstAb.GetComponent<Image>().color = Color.green;
            Star = GameObject.FindGameObjectsWithTag("Star");
            for (int i = 0; i < Star.Length; i++)
            {
                Star[i].GetComponent<SpriteRenderer>().color = Color.red;
                StartCoroutine(StarMoneyGo());
                StartCoroutine(FirtstAbStart());
            }
        }
       
    }
    public void Update()
    {
        StarMoney = Star.Length; //жизни от звезды
        if (!FACheck && StartBool)
        {
            StartCoroutine(FirtstAbWait());
            TimeFAb = FindObjectOfType<Load>().TimeTAbSave;

        }
        if (FACheck && TimeKDF == 0f)
        {
            FirstAb.GetComponent<Image>().color = Color.white;
        }

            

    }
    private IEnumerator FirtstAbStart()
    {
        PlayerPrefs.SetFloat("KDStar", 15f);
        TimeKDF = PlayerPrefs.GetFloat("KDStar");
        
        yield return new WaitForSeconds(TimeFAb);
        FACheck = false;
        nach = true;
        FirstAb.GetComponent<Image>().color = Color.red;
    

    }
    private IEnumerator FirtstAbWait()
    {
        Star = GameObject.FindGameObjectsWithTag("Star");
        for (int i = 0; i < Star.Length; i++)
        {
            Star[i].GetComponent<SpriteRenderer>().color = Color.white;          
        }
        StartBool = false;
        yield return new WaitForSeconds(TimeKDF);
        TimeKDF = 0f;
        FACheck = true;
        StartBool = true;

    }
    private IEnumerator StarMoneyGo()
    {
          
        while (!nach)
        {
            yield return new WaitForSeconds(0.1f); if (FindObjectOfType<Load>().PrestigeSave != 0)
            {
                FindObjectOfType<InfoPlanet>().hpPlanet += StarMoney * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX * (FindObjectOfType<Load>().PrestigeSave + 1);
                FindObjectOfType<InfoPlanet>().hpWas += StarMoney * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX * (FindObjectOfType<Load>().PrestigeSave + 1);
            }
            else
            {
                FindObjectOfType<InfoPlanet>().hpPlanet += StarMoney * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
                FindObjectOfType<InfoPlanet>().hpWas += StarMoney * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
            }
        }
    }
       
            
       


   
}

