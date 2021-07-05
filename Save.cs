using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Save : MonoBehaviour
{
    public string filename;
    public int secondPassef;
    private void Start()
    {
        DateTime lastSaveTime = Utils.GetDateTime("LastSaveTime", DateTime.UtcNow);
        TimeSpan timePassed = DateTime.UtcNow - lastSaveTime;
        secondPassef = (int)timePassed.TotalSeconds;
        secondPassef = Mathf.Clamp(secondPassef, 0, 7 * 24 * 60 * 60);
        if (filename == "")
        {
            filename = "Assets/Res/Peremen.txt";
        }
       
        
    }
  
    private void OnApplicationQuit()
    {
        StreamWriter sw = new StreamWriter(filename);
        PlayerPrefs.SetFloat("KDF",FindObjectOfType<AbilityScr>().TimeKDF);
        PlayerPrefs.SetFloat("KDS", FindObjectOfType<SecondSkil>().TimeKDF);
        PlayerPrefs.SetFloat("KDT", FindObjectOfType<ThirdSkil>().TimeKDF);
        PlayerPrefs.SetFloat("KDStar", FindObjectOfType<StarfallSkil>().TimeKDF);
        PlayerPrefs.SetFloat("KDDEf", FindObjectOfType<DefenderSkil>().TimeKDF);
        sw.WriteLine(FindObjectOfType<InfoPlanet>().hpPlanet);
        sw.WriteLine(FindObjectOfType<InfoPlanet>().click);
        sw.WriteLine(FindObjectOfType<InfoPlanet>().pasIncome);
        sw.WriteLine(FindObjectOfType<Load>().TimeFAbSave);
        sw.WriteLine(FindObjectOfType<Load>().TimeSAbSave);
        sw.WriteLine(FindObjectOfType<Load>().TimeTAbSave);
        sw.WriteLine(FindObjectOfType<InfoPlanet>().StarNumber);
        sw.WriteLine(FindObjectOfType<Load>().TimeStarSave);
        sw.WriteLine(FindObjectOfType<Load>().TimeDEF);
        sw.WriteLine(FindObjectOfType<Load>().PrestigeSave);
        sw.WriteLine(FindObjectOfType<InfoPlanet>().hpWas);
        sw.Close();
        Utils.SetDataTime("LastSaveTime", DateTime.UtcNow);

    }
}
