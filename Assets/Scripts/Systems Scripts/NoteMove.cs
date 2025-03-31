using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;
    }
}
