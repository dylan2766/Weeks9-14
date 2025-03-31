using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerA : MonoBehaviour
{
    public GameObject prefab;
    public float t;
    public float chance;
    public float endPos;

    public bool redA = false;
    public bool yellowS = false;
    public bool blueD = false;

    public GameObject newNote;

    public List<GameObject> spawnedNotes;

    void Start()
    {
        spawnedNotes = new List<GameObject>();
    }

    public void Update()
    {

        Vector2 pos = transform.position;
        transform.position = pos;

        t += Time.deltaTime;
        if (t > 2)
        {
            chance = Random.Range(0, 2);
            if(chance >= 1)
            {
                newNote = Instantiate(prefab, pos, Quaternion.identity);

                spawnedNotes.Add(newNote);

                NoteMove spawnedNote = newNote.GetComponent<NoteMove>();

                spawnedNote.noteSpawner = this;

                spawnedNote.aOn = redA;
                spawnedNote.sOn = yellowS;
                spawnedNote.dOn = blueD;

                redA = spawnedNote.aOn;
                yellowS = spawnedNote.sOn;
                blueD = spawnedNote.dOn;
            }
            t = 0;
        }
    }
}
