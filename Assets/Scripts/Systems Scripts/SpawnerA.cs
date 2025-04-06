using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class SpawnerA : MonoBehaviour
{
    public GameObject prefab;
    public float t;
    public float chance;
    public float endPos;

    public float speed;

    public GameObject redButton;
    public GameObject yellowButton;
    public GameObject blueButton;

    public GameObject newNote;

    public UnityEvent OnClick;

    public List<GameObject> spawnedNotes;

    void Start()
    {
        speed = 1;
        spawnedNotes = new List<GameObject>();
    }

    public void Update()
    {
        Vector2 pos = transform.position;
        transform.position = pos;

        t += Time.deltaTime;
        if (t > speed)
        {
            chance = Random.Range(0, 2);
            if (chance >= 1)
            {
                newNote = Instantiate(prefab, pos, Quaternion.identity);

                spawnedNotes.Add(newNote);

                NoteMove spawnedNote = newNote.GetComponent<NoteMove>();

                spawnedNote.noteSpawner = this;
            }
            t = 0;
        }
    }
}
