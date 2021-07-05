using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundScr : MonoBehaviour
{
    public AudioClip[] otherClip;
    public GameObject On;
    public GameObject Off;
    IEnumerator Start()
    {
        for (int i = 0; i < otherClip.Length; i++)
        {
            if (i == otherClip.Length - 1)
            {
                i = 0;
            }
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = otherClip[i];
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
        }

    }
    void Update()
    {
        Start();

    }
    public void OfMuz()
    {        
        GetComponent<AudioSource>().volume = 0f;
        Off.SetActive(false);
        On.SetActive(true);
    }
    public void OnMuz()
    {
        GetComponent<AudioSource>().volume = 1f;
        Off.SetActive(true);
        On.SetActive(false);
    }

}
