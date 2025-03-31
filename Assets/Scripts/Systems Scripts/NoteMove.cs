using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteMove : MonoBehaviour
{
    public float speed;
    public SpawnerA noteSpawner;
    public RedButton redButton;
    public YellowButton yellowButton;
    public BlueButton blueButton;
    public Score score;
    public float destroyTime;

    public bool points = false;
    public bool losePoints = false;

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
            Score score = GetComponent<Score>();
            
            if((pos.x >= -8.2f && pos.x <= -6f && pos.y <= 2.1f && pos.y >= 1.9f))
            {
                Destroy(gameObject);
                score.currentScore = score.currentScore + 100;
            }
            else
            {
                score.currentScore = score.currentScore - 50;
            }

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Score score = GetComponent<Score>();

            if ((pos.x >= -8.2f && pos.x <= -6f && pos.y <= 0.1f && pos.y >= -0.1f))
            {
                Destroy(gameObject);
                score.currentScore = score.currentScore + 100;
            }
            else
            {
                score.currentScore = score.currentScore - 50;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Score score = GetComponent<Score>();

            if ((pos.x >= -8.2f && pos.x <= -6f && pos.y <= -1.9f && pos.y >= -2.1f))
            {
                Destroy(gameObject);
                score.currentScore = score.currentScore + 100;
            }
            else
            {
                score.currentScore = score.currentScore - 50;
            }
        }

        Destroy(gameObject,destroyTime);
    }
}
