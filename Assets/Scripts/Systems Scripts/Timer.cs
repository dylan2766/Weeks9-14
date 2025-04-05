using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

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
        boost = 1;
        t = 60;
        StartCoroutine(TimerOn());
    }
    public IEnumerator TimerOn()
    {
        t = 60;
        while (t > 0)
        {
            t = t - (Time.deltaTime * boost);

            yield return null;
        }
    }

    public void Update()
    {
        text.text = "Timer: " + Mathf.Round(t);

        if (t < 0.1f)
        {
            t = 0;
            spawnerAScript.enabled = false;
            spawnerSScript.enabled = false;
            spawnerDScript.enabled = false;
            redScript.enabled = false;
            yellowScript.enabled = false;
            blueScript.enabled = false;
            boostScript.enabled = false;
        }
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
