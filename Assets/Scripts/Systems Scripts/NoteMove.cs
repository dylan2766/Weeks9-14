using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class NoteMove : MonoBehaviour
{
    public float speed;
    public SpawnerA noteSpawner;
    public RedButton redButton;
    public YellowButton yellowButton;
    public BlueButton blueButton;
    public float destroyTime;

    void Start()
    {
        destroyTime = 5;
    }

    public void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.A))
        {
            if ((pos.x >= -9f && pos.x <= -6f && pos.y <= 2.1f && pos.y >= 1.9f))
            {
                Destroy(gameObject);
            }

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if ((pos.x >= -9f && pos.x <= -6f && pos.y <= 0.1f && pos.y >= -0.1f))
            {
                Destroy(gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if ((pos.x >= -9f && pos.x <= -6f && pos.y <= -1.9f && pos.y >= -2.1f))
            {
                Destroy(gameObject);
            }
        }

        Destroy(gameObject,destroyTime);
    }
}
