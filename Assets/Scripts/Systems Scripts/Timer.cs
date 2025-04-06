using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    //Variables
    public float t;
    public SpawnerA spawnerAScript;
    public SpawnerA spawnerSScript;
    public SpawnerA spawnerDScript;
    public RedButton redScript;
    public YellowButton yellowScript;
    public BlueButton blueScript;
    public Boost boostScript;

    public TextMeshProUGUI text;

    public float boost;

    public void Start()
    {
        //Sets boost speed to 1 sets timer start to 60 seconds and starts the coroutine that begins the timer
        boost = 1;
        t = 60;
        StartCoroutine(TimerOn());
    }

    //Counts the time down while it is above 0
    public IEnumerator TimerOn()
    {
        t = 60;
        while (t > 0)
        {
            //if boost is active the timer drains faster
            t = t - (Time.deltaTime * boost);

            yield return null;
        }
    }

    public void Update()
    {
        //sets the text of the timer to be t rounded
        text.text = "Timer: " + Mathf.Round(t);

        //if the time is less the 0.1 second stop the coroutine for the timer set the time to 0 and disable all the scripts
        if (t < 0.1f)
        {
            StopCoroutine(TimerOn());
            t = 0;
            spawnerAScript.enabled = false;
            spawnerSScript.enabled = false;
            spawnerDScript.enabled = false;
            redScript.enabled = false;
            yellowScript.enabled = false;
            blueScript.enabled = false;
            boostScript.enabled = false;
        }
        //if time is above 0 keep scripts active or reactivate them
        else
        {
            spawnerAScript.enabled = true;
            spawnerSScript.enabled = true;
            spawnerDScript.enabled = true;
            redScript.enabled = true;
            yellowScript.enabled = true;
            blueScript.enabled = true;
            boostScript.enabled = true;
        }
    }
}
