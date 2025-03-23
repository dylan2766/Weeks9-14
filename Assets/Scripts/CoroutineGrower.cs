using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineGrower : MonoBehaviour
{
    public AnimationCurve curve;
    public AnimationCurve appleCurve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;
    public Transform apple;

    public void StartGrowing()
    {
        StartCoroutine(Grow());
    }

    public IEnumerator Grow()
    {
        apple.localScale = Vector3.zero;
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
            yield return null;
        }

        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            apple.localScale = Vector3.one * maxSize * appleCurve.Evaluate(t);
            yield return null;
        }
    }
}
