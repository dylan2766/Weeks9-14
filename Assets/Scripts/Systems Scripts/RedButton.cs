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
    public float min = 0;
    public float max = 1;

    public void Start()
    {
        t = 1;
        colour.a = (curve.Evaluate(t) / 1.5f) * 1.3f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && t >= 1f)
        {
            ClickedOn();
        }
        image.color = colour;
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
            t += Time.deltaTime;
            transform.localScale = Vector3.one * max * curve.Evaluate(t);
            colour.a = (curve.Evaluate(t)/1.5f) * 1.3f;
            yield return null;
        }
    }
}
