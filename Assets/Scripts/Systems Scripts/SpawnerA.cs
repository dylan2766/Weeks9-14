using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerA : MonoBehaviour
{
    public GameObject prefab;
    public float t;
    public float chance;


    void Update()
    {
        Vector2 pos = transform.position;
        transform.position = pos;

        t += Time.deltaTime;
        if (t > 2)
        {
            chance = Random.Range(0, 2);
            if(chance >= 1)
            {
                Instantiate(prefab, pos, Quaternion.identity);
            }
            t = 0;
        }
    }
}
