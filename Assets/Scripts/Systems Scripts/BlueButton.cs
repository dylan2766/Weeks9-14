using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BlueButton : MonoBehaviour
{
    public Image image;
    public Color colour;
    public AnimationCurve curve;
    public float t = 1;
    public float tB = 0;
    public float min = 0;
    public float max = 1;

    public SpriteRenderer sr;

    public SpawnerA blueSpawner;

    public void Start()
    {
        t = 1;
        colour.a = (curve.Evaluate(t) / 3f) * 1.5f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && t >= 1f)
        {
            blueSpawner.blueD = true;
            ClickedOn();
        }
        image.color = colour;

        //Changes Blue D button to on and off after 1 seconds
        if (blueSpawner.blueD == true)
        {
            tB += Time.deltaTime;

            if (tB >= 0.5f)
            {
                tB = 0;
                blueSpawner.blueD = false;
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
