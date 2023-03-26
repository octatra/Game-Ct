using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Audio;

    public void MusikOn()
    {
        Audio.Play();
        Time.timeScale = 1;
    }

    public void MusikOff()
    {
        Audio.Stop();
    }
}
