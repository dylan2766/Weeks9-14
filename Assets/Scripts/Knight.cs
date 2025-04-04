using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Tilemaps;

public class Knight : MonoBehaviour
{

    public float speed = 2;
    Animator animator;
    SpriteRenderer sr;
    public bool canRun = true;

    public Tilemap tilemap;
    public Tile grass;
    public Tile stone;

    public CinemachineImpulseSource impulseSource;

    public AudioSource spongebob;
    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3Int gridPos = tilemap.WorldToCell(mousePos);

        if (Input.GetKeyDown(KeyCode.Space) && tilemap.GetTile(gridPos) == stone)
        {
            transform.position = mousePos;
        }

        float direction = Input.GetAxis("Horizontal");
        sr.flipX = direction < 0;

        animator.SetFloat("speed", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }
        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
    }

    public void AttackHasFinished()
    {
        Debug.Log("The attack has finished!");
        canRun = true;
    }

    public void SoundFunctionThing()
    {
        spongebob.Play();
        impulseSource.GenerateImpulse();
    }
    public void SoundFunctionThing1()
    {
        spongebob.Play();
        impulseSource.GenerateImpulse();
    }
    public void SoundFunctionThing2()
    {
        spongebob.Play();
        impulseSource.GenerateImpulse();
    }
}
