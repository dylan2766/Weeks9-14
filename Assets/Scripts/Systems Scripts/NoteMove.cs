using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public float speed;
    public SpawnerA noteSpawner;

    void Start()
    {

    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x >= -11)
        {
            Destroy(gameObject,5);
        }
    }
}
