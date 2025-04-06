using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class NoteMove : MonoBehaviour
{
    //variables
    public float speed;
    public SpawnerA noteSpawner;
    public RedButton redButton;
    public YellowButton yellowButton;
    public BlueButton blueButton;

    public void Update()
    {
        //setting position variable
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        //Checks if the "A" or "S" or "D" is pressed then also checks if the note is within the buttons area. If it all is true it will destroy the object
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
    }
}
