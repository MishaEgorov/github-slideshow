using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreScr : MonoBehaviour
{
    public GameObject UpPanel;
    public Text InfoBuy;
    public Button BuyButt;
    public GameObject Lock;
    public GameObject StartPref;
    public int UpChet;
    public GameObject[] Star;
   

    public void openUppanel()
    {
        UpPanel.SetActive(true);
    }

    public void closeUppanel()
    {
        UpPanel.SetActive(false);
    }

    public void CLikUP()
    {
        UpChet = 0;
        InfoBuy.text = "На данный момент Ваш доход от клика составляет: "+ FindObjectOfType<InfoPlanet>().click + " Вы можите улучшить доход от клика на 1. Стоимость данной услуги составит: "+ FindObjectOfType<InfoPlanet>().click * 50+" жизней.";
        if (FindObjectOfType<InfoPlanet>().hpPlanet < FindObjectOfType<InfoPlanet>().click * 50)
        {
            Lock.SetActive(true);
        }
        else
        {
            Lock.SetActive(false);
        }
    }
    public void PasIncomeUP()
    {
        UpChet = 1;
        InfoBuy.text = "На данный момент Ваш пассивный доход составляет: " + FindObjectOfType<InfoPlanet>().pasIncome + " Вы можите улучшить пассивный доход от клика. Стоимость данной услуги составит: " + (FindObjectOfType<InfoPlanet>().pasIncome + 5)*50 + " жизней.";
        if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<InfoPlanet>().pasIncome + 5) * 50)
        {
            Lock.SetActive(true);
        }
        else
        {
            Lock.SetActive(false);
        }
    }
    public void StarIncomeUP()
    {
        if(FindObjectOfType<InfoPlanet>().hpPlanet>=3000)
        {
            if (FindObjectOfType<InfoPlanet>().StarNumber >= 10)
            {
                InfoBuy.text = "У вас максимальное количество здёзд.";
                Lock.SetActive(true);
            }
            else
            {
                UpChet = 5;
                InfoBuy.text = "На данный момент у Вас: " + FindObjectOfType<InfoPlanet>().StarNumber + " звёзд. Вы можите увеличить их количество. Стоимость данной услуги составит: " + (FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150) + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150 && FindObjectOfType<InfoPlanet>().StarNumber != 10)
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }
            }
        }
        else
        {
            InfoBuy.text = "У вас слишком мало жизней.";
            Lock.SetActive(true);
        }
        
        
    }
    public void UpTimeTriplCleck()
    {
        if (FindObjectOfType<InfoPlanet>().hpPlanet >= 500)
        {
            UpChet = 2;
            InfoBuy.text = "На данный момент длительность Вашего тройного нажатия= " + FindObjectOfType<Load>().TimeFAbSave + " секунд. Вы можите увеличить его длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeFAbSave + 1 * 100) + " жизней.";
            if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeFAbSave + 1 * 100))
            {
                Lock.SetActive(true);
            }
            else
            {
                Lock.SetActive(false);
            }
        }
        else
        {
            InfoBuy.text = "У вас слишком мало жизней.";
            Lock.SetActive(true);
        }
           
    }
    public void UpTimeDoubleX()
    {
        if (FindObjectOfType<InfoPlanet>().hpPlanet >= 1000)
        {
            UpChet = 3;
            InfoBuy.text = "На данный момент длительность Вашего бонуса X2= " + FindObjectOfType<Load>().TimeSAbSave + " секунд. Вы можите увеличить его длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeSAbSave + 1 * 100) + " жизней.";
            if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeSAbSave + 1 * 100))
            {
                Lock.SetActive(true);
            }
            else
            {
                Lock.SetActive(false);
            }
        }
        else
        {
            InfoBuy.text = "У вас слишком мало жизней.";
            Lock.SetActive(true);
        }
       
    }
    public void UpTimeFifthX()
    {
        if (FindObjectOfType<InfoPlanet>().hpPlanet >= 2000)
        {
            UpChet = 4;
            InfoBuy.text = "На данный момент длительность Вашего бонуса X5= " + FindObjectOfType<Load>().TimeTAbSave + " секунд. Вы можите увеличить его длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeTAbSave + 1 * 100) + " жизней.";
            if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeTAbSave + 1 * 100))
            {
                Lock.SetActive(true);
            }
            else
            {
                Lock.SetActive(false);
            }
        }
        else
        {
            InfoBuy.text = "У вас слишком мало жизней.";
            Lock.SetActive(true);
        }
           
    }
    public void DefenderClick()
    {
        if (FindObjectOfType<InfoPlanet>().hpPlanet >= 4000)
        {
            UpChet = 6;
            InfoBuy.text = "На данный момент длительность Вашей защиты: " + FindObjectOfType<Load>().TimeDEF + " секунд. Вы можите увеличить её длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeDEF + 1 * 100) + " жизней.";
            if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeDEF + 1 * 100))
            {
                Lock.SetActive(true);
            }
            else
            {
                Lock.SetActive(false);
            }
        }
        else
        {
            InfoBuy.text = "У вас слишком мало жизней.";
            Lock.SetActive(true);
        }
          
    }
    public void Prestige()
    {
        UpChet = 7;
        InfoBuy.text = "На данный момент Ваш престиж равен: " + FindObjectOfType<Load>().PrestigeSave + " Вы можите получить его. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().PrestigeSave + 1 * 100) + " жизней.";
        if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().PrestigeSave + 1 * 100))
        {
            Lock.SetActive(true);
        }
        else
        {
            Lock.SetActive(false);
        }
    }
    public void Buy()
    {
        if(UpChet==0)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= FindObjectOfType<InfoPlanet>().click * 50)
            {
                Lock.SetActive(false);
                FindObjectOfType<InfoPlanet>().hpPlanet -= FindObjectOfType<InfoPlanet>().click * 50;
                FindObjectOfType<InfoPlanet>().click += 1;
                // UpPanel.SetActive(false);
                InfoBuy.text = "На данный момент Ваш доход от клика составляет: " + FindObjectOfType<InfoPlanet>().click + " Вы можите улучшить доход от клика на 1. Стоимость данной услуги составит: " + FindObjectOfType<InfoPlanet>().click * 50 + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < FindObjectOfType<InfoPlanet>().click * 50)
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }
            }
        }
        if (UpChet == 1)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<InfoPlanet>().pasIncome + 5) * 50)
            {
                Lock.SetActive(false);
                FindObjectOfType<InfoPlanet>().hpPlanet -= (FindObjectOfType<InfoPlanet>().pasIncome + 5) * 50;
                FindObjectOfType<InfoPlanet>().pasIncome += 1;
                
                InfoBuy.text = "На данный момент Ваш пассивный доход составляет: " + FindObjectOfType<InfoPlanet>().pasIncome + " Вы можите улучшить пассивный доход от клика. Стоимость данной услуги составит: " + (FindObjectOfType<InfoPlanet>().pasIncome + 5) * 50 + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<InfoPlanet>().pasIncome + 5) * 50)
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }
            }
        }
        if (UpChet == 3)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<Load>().TimeSAbSave + 1 * 100))
            {
                Lock.SetActive(false);
                FindObjectOfType<Load>().TimeSAbSave += 5;
                FindObjectOfType<InfoPlanet>().hpPlanet -= (int)FindObjectOfType<Load>().TimeSAbSave + 1 * 100;
                
                InfoBuy.text = "На данный момент длительность Вашего бонуса X2= " + FindObjectOfType<Load>().TimeSAbSave + " секунд. Вы можите увеличить его длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeSAbSave + 1 * 100) + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeSAbSave + 1 * 100))
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }
            }
        }
        if (UpChet == 2)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<Load>().TimeFAbSave + 1 * 100))
            {
                Lock.SetActive(false);
                FindObjectOfType<Load>().TimeFAbSave += 5;
                FindObjectOfType<InfoPlanet>().hpPlanet -= (int)FindObjectOfType<Load>().TimeFAbSave + 1 * 100;
                InfoBuy.text = "На данный момент длительность Вашего тройного нажатия= " + FindObjectOfType<Load>().TimeFAbSave + " секунд. Вы можите увеличить его длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeFAbSave + 1 * 100) + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeFAbSave + 1 * 100))
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }
            }
        }
        if (UpChet == 4)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<Load>().TimeTAbSave + 1 * 100))
            {
                Lock.SetActive(false);
                FindObjectOfType<Load>().TimeTAbSave += 5;
                FindObjectOfType<InfoPlanet>().hpPlanet -= (int)FindObjectOfType<Load>().TimeTAbSave + 1 * 100;
                
            }
        }
        if (UpChet == 5)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150))
                {
                Lock.SetActive(false);
                FindObjectOfType<InfoPlanet>().hpPlanet -= (FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150);
                FindObjectOfType<InfoPlanet>().StarNumber += 1;
                FindObjectOfType<GameManager>().StarSpawn();
                if (FindObjectOfType<InfoPlanet>().StarNumber >= 10)
                {
                    InfoBuy.text = "У вас максимальное количество здёзд.";
                    Lock.SetActive(true);
                }
                else
                {
                    UpChet = 5;
                    InfoBuy.text = "На данный момент у Вас: " + FindObjectOfType<InfoPlanet>().StarNumber + " звёзд. Вы можите увеличить их количество. Стоимость данной услуги составит: " + (FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150) + " жизней.";
                    if (FindObjectOfType<InfoPlanet>().hpPlanet < FindObjectOfType<InfoPlanet>().StarNumber + 1 * 150 && FindObjectOfType<InfoPlanet>().StarNumber != 10)
                    {
                        Lock.SetActive(true);
                    }
                    else
                    {
                        Lock.SetActive(false);
                    }
                }
            }
                
        }
        if (UpChet == 6)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<Load>().TimeDEF + 1 * 100))
            {
                Lock.SetActive(false);
                FindObjectOfType<Load>().TimeDEF += 5;
                FindObjectOfType<InfoPlanet>().hpPlanet -= (int)FindObjectOfType<Load>().TimeDEF + 1 * 100;
                InfoBuy.text = "На данный момент длительность Вашей защиты: " + FindObjectOfType<Load>().TimeDEF + " секунд. Вы можите увеличить её длительность на 5 секунд. Стоимость данной услуги составит: " + (FindObjectOfType<Load>().TimeDEF + 1 * 100) + " жизней.";
                if (FindObjectOfType<InfoPlanet>().hpPlanet < (FindObjectOfType<Load>().TimeDEF + 1 * 100))
                {
                    Lock.SetActive(true);
                }
                else
                {
                    Lock.SetActive(false);
                }

            }
        }
        if (UpChet == 7)
        {
            if (FindObjectOfType<InfoPlanet>().hpPlanet >= (FindObjectOfType<Load>().PrestigeSave + 1 * 100))
            {
                Lock.SetActive(false);
                FindObjectOfType<Load>().PrestigeSave += 1;
                Instantiate(FindObjectOfType<PrestigeScr>().Satellite);
                FindObjectOfType<InfoPlanet>().hpPlanet -= (int)FindObjectOfType<Load>().PrestigeSave + 1 * 100;
                FindObjectOfType<InfoPlanet>().click = 1;
                FindObjectOfType<InfoPlanet>().hpPlanet = 0;
                FindObjectOfType<InfoPlanet>().hpWas = 0;
                FindObjectOfType<InfoPlanet>().StarNumber = 0;
                FindObjectOfType<InfoPlanet>().pasIncome = 0;
                FindObjectOfType<Load>().TimeDEF = 5;
                FindObjectOfType<Load>().TimeFAbSave = 5;
                FindObjectOfType<Load>().TimeSAbSave = 5;
                FindObjectOfType<Load>().TimeStarSave = 5;
                FindObjectOfType<Load>().TimeTAbSave = 5;
                UpPanel.SetActive(false);
         
                    Star = GameObject.FindGameObjectsWithTag("Star");
                for (int i = 0; i < Star.Length; i++)
                {
                    Destroy(Star[i]);
                }
            }
        }
    }

}
