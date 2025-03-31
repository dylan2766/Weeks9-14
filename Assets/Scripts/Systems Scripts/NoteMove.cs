using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public float speed;
    public SpawnerA noteSpawner;
    public float destroyTime;

    public bool aOn = false;
    public bool sOn = false;
    public bool dOn = false;

    void Start()
    {
        destroyTime = 5;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        if ((pos.x >= -8 && pos.x <= -6 && pos.y == 2) && aOn == true)
        {
            Debug.Log("A WORKED");
        }

        if ((pos.x >= -8 && pos.x <= -6 && pos.y == 0) && sOn == true)
        {
            Debug.Log("S WORKED");
        }

        if ((pos.x >= -8 && pos.x <= -6 && pos.y == -2) && dOn == true)
        {
            Debug.Log("D WORKED");
        }

        Destroy(gameObject,destroyTime);
    }
}
