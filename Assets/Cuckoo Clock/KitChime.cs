using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock clock;
    public AudioSource sound;
    private void Start()
    {
        clock.OnTheHour.AddListener(Chime);
    }

    public void Chime(int hour)
    {
        sound.Play();
        Debug.Log("Chiming " + hour + " o'clock");
    }

    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming !");
    }
}
