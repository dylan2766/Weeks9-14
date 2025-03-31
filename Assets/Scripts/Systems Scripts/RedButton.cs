using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RedButton : MonoBehaviour
{
    public Image image;
    public Color colour;
    public AnimationCurve curve;
    public float t = 1;
    public float tR = 0;
    public float tY = 0;
    public float tB = 0;
    public float min = 0;
    public float max = 1;

    public SpawnerA noteSpawner;

    public void Start()
    {
        t = 1;
        colour.a = (curve.Evaluate(t) / 3f) * 1.5f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && t >= 1f)
        {
            noteSpawner.redA = true;
            noteSpawner.yellowS = true;
            ClickedOn();
        }
        image.color = colour;
        
        //Changes Red A button to on and off after 1 second
        if(noteSpawner.redA == true)
        {
            tR += Time.deltaTime;

            if(tR >= 1)
            {
                tR = 0;
                noteSpawner.redA = false;
            }
        }

        //Changes Yellow S button to on and off after 1 seconds
        if (noteSpawner.yellowS == true)
        {
            tY += Time.deltaTime;

            if (tY >= 1)
            {
                tY = 0;
                noteSpawner.yellowS = false;
            }
        }

        //Changes Blue D button to on and off after 1 seconds
        if (noteSpawner.blueD == true)
        {
            tB += Time.deltaTime;

            if (tB >= 1)
            {
                tB = 0;
                noteSpawner.blueD = false;
            }
        }
    }

    public void ClickedOn()
    {
        StartCoroutine(Clicked());
    }

    public IEnumerator Clicked()
    {
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * 3;
            transform.localScale = Vector3.one * max * curve.Evaluate(t);
            colour.a = (curve.Evaluate(t) / 3f) * 1.5f;
            yield return null;
        }
    }
}
