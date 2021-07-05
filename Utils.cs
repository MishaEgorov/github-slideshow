using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils 
{
    public static void SetDataTime(string key, DateTime value)
    {
        string convertedToString = value.ToString("u",CultureInfo.InvariantCulture);
        PlayerPrefs.SetString(key, convertedToString);
    }

    public static DateTime GetDateTime(string key, DateTime defvalue)
    {
        if(PlayerPrefs.HasKey(key))
        {
            string stored = PlayerPrefs.GetString(key);
            DateTime result = DateTime.ParseExact(stored, "u", CultureInfo.InvariantCulture);
            return result;
        }
        else
        {
            return defvalue;
        }
    }
}
