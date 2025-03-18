using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatScript : MonoBehaviour
{
    //Write a coroutine that makes a sprite do something (grow, move, rotate, etc) using an AnimationCurve.

    public AnimationCurve BATMANBOOGIE;
    public Vector3 SIZE;

    public float t;

    Coroutine sizeChange;

    void Start()
    {
        
    }

    void Update()
    {


        t += Time.deltaTime;

        if (t > 3)
        {
            t = 0;
        }

        BATMANBOOGIE.Evaluate(t);

        transform.localScale = Vector2.one * BATMANBOOGIE.Evaluate(t);
    }
}
