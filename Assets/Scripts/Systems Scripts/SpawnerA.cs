using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerA : MonoBehaviour
{
    public GameObject prefab;
    public float t;


    void Update()
    {
        Vector2 pos = transform.position;
        transform.position = pos;

        t += Time.deltaTime;
        if (t > 2)
        {
            Instantiate(prefab, pos, Quaternion.identity);
            t = 0;
        }
    }
}
