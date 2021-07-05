using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject StorePanel;
    public Vector3[] vec;
    public GameObject prefStar;
    public void OpenStore()
    {
        StorePanel.SetActive(true);
    }

    public void ClosePanel()
    {
        StorePanel.SetActive(false);
    }
   public void StarSpawn()
    {
        int rand = Random.Range(0, vec.Length - 1);          
        Instantiate(prefStar, vec[rand], Quaternion.identity);
        RemoveAt(ref vec, rand);
    }

    static void RemoveAt(ref Vector3[] array, int index)
    {
        Vector3[] newArray = new Vector3[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }
        for (int i = index + 1; i < array.Length; i++)
        {
            newArray[i - 1] = array[i];
        }
        array = newArray;
    }
}
