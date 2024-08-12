using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviorScript : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
  
    public void HideUIText(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void UnhideUIText(GameObject obj)
    {
        obj.SetActive(true);
    }

      public void PlayAudio()
    {
        if (audioSource1 != null)
        {
            audioSource1.Play();
        }
    }
    public void PlayAudio2()
    {
        if (audioSource2 != null)
        {
            audioSource2.Play();
        }
    }
    public void PlayAudio3()
    {
        if (audioSource3 != null)
        {
            audioSource3.Play();
        }
    }
    public void PlayAudio4()
    {
        if (audioSource4 != null)
        {
            audioSource4.Play();
        }
    }
    public void PlayAudio5()
    {
        if (audioSource5 != null)
        {
            audioSource5.Play();
        }
    }
}
 

