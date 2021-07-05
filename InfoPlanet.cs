using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPlanet : MonoBehaviour
{
    public int hpWas;
    public int hpPlanet;
    public Text hpText;
    public Text ClikcText;
    public Text PasText;
    public int click;
    public int pasIncome;
    public int StarNumber;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public Animator animator;
    void Start()
    {
        StarNumber = FindObjectOfType<Load>().StarSaveT;
        StartCoroutine(PasIncomeTime());
        pasIncome = FindObjectOfType<Load>().pasIncomeSave;
        hpPlanet = FindObjectOfType<Load>().hpSave + FindObjectOfType<Save>().secondPassef * pasIncome; 
        hpWas= FindObjectOfType<Load>().hpWasSave + FindObjectOfType<Save>().secondPassef * pasIncome;
        click = FindObjectOfType<Load>().clickSave;
        if(click==0)
        {
            click = 1;
        }
     for(int i=0;i<StarNumber;i++)
        {

         FindObjectOfType<GameManager>().StarSpawn();
        }
    }
    public void OnMouseDown()
    {
        animator.SetBool("IsClick", true);
        if (FindObjectOfType<Load>().PrestigeSave != 0)
        {
            hpPlanet += (click * FindObjectOfType<AbilityScr>().startClick * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX)* (FindObjectOfType<Load>().PrestigeSave+1);
            hpWas+= (click * FindObjectOfType<AbilityScr>().startClick * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX) * (FindObjectOfType<Load>().PrestigeSave + 1);
        }
        else
        {
            hpPlanet += click * FindObjectOfType<AbilityScr>().startClick * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
            hpWas += click * FindObjectOfType<AbilityScr>().startClick * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
        }      
    }
    public void OnMouseUp()
    {
        animator.SetBool("IsClick", false);
    }
    void Update()
    {

        hpText.text = "Количество жизней: "+hpPlanet.ToString();     
        ClikcText.text ="Прирост с нажатия: " + (click * FindObjectOfType<AbilityScr>().startClick).ToString();
        PasText.text = "Пассивный прирост: " + pasIncome.ToString();
        СheckingLives();
    }
    private IEnumerator PasIncomeTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (FindObjectOfType<Load>().PrestigeSave != 0)
            {
                hpPlanet += pasIncome * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX*(FindObjectOfType<Load>().PrestigeSave + 1);
                hpWas += pasIncome * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX*(FindObjectOfType<Load>().PrestigeSave + 1);
            }
            else
            {
                hpPlanet += pasIncome * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
                hpWas += pasIncome * FindObjectOfType<SecondSkil>().dobX * FindObjectOfType<ThirdSkil>().dobX;
            }
        }
    }
   public void СheckingLives()
    {
        if(hpWas>=500)
        {
            but1.SetActive(true);
        }
        else
        {
            but1.SetActive(false);
        }

        if (hpWas >= 1000)
        {
            but2.SetActive(true);
        }
        else
        {
            but2.SetActive(false);
        }

        if (hpWas >= 2000)
        {
            but3.SetActive(true);
        }
        else
        {
            but3.SetActive(false);
        }

        if (hpWas >= 3000 && StarNumber > 0)
        {
            but4.SetActive(true);
        }
        else
        {
            but4.SetActive(false);
        }

        if (hpWas >= 4000)
        {
            but5.SetActive(true);
        }
        else
        {
            but5.SetActive(false);
        }

    }
}
