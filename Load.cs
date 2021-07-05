using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Load : MonoBehaviour
{
    public int hpSave;
    public int hpWasSave;
    public int clickSave;
    public int pasIncomeSave;
    public float TimeFAbSave;
    public float TimeSAbSave;
    public float TimeTAbSave;
    public int StarSaveT;
    public float TimeStarSave;
    public float TimeDEF;
    public int PrestigeSave;
    void Awake()
    {
        StreamReader streamReader = new StreamReader("Assets/Res/Peremen.txt");
        if(streamReader!=null)
        {
            while(!streamReader.EndOfStream)
            {
                hpSave = System.Convert.ToInt32(streamReader.ReadLine());
                clickSave=System.Convert.ToInt32(streamReader.ReadLine());
                pasIncomeSave = System.Convert.ToInt32(streamReader.ReadLine());
                TimeFAbSave = System.Convert.ToSingle(streamReader.ReadLine());
                TimeSAbSave = System.Convert.ToSingle(streamReader.ReadLine());
                TimeTAbSave = System.Convert.ToSingle(streamReader.ReadLine());
                StarSaveT = System.Convert.ToInt32(streamReader.ReadLine());
                TimeStarSave = System.Convert.ToSingle(streamReader.ReadLine());
                TimeDEF = System.Convert.ToSingle(streamReader.ReadLine());
                PrestigeSave = System.Convert.ToInt32(streamReader.ReadLine());
                hpWasSave= System.Convert.ToInt32(streamReader.ReadLine());
            }
        }
    }

}
