using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class SpawnerA : MonoBehaviour
{
    //variables
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

    //starting values
    void Start()
    {
        speed = 1;
        spawnedNotes = new List<GameObject>();
    }

    public void Update()
    {
        //set pos variable
        Vector2 pos = transform.position;
        transform.position = pos;

        //timer to space out the spawning of the notes
        t += Time.deltaTime;
        if (t > speed)
        {
            //checks for a random number between 0 and 2 and if its >= 1 then it will spawn a prefab
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
