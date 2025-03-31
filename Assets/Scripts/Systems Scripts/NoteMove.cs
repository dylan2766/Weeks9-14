using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Update()
    {
       
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        if ((pos.x >= -8f && pos.x <= -6.2f && pos.y <= 2.1f && pos.y >= 1.9f) && Input.GetKeyDown(KeyCode.A))
        {
            Destroy(gameObject);
            Debug.Log("A WORKED");
        }

        if ((pos.x >= -8f && pos.x <= -6.2f && pos.y <= 0.1f && pos.y >= -0.1f) && Input.GetKeyDown(KeyCode.S))
        {
            Destroy(gameObject);
            Debug.Log("S WORKED");
        }

        if ((pos.x >= -8f && pos.x <= -6.2f && pos.y <= -1.9f && pos.y >= -2.1f) && Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject);
            Debug.Log("D WORKED");
        }

        Destroy(gameObject,destroyTime);
    }
}
