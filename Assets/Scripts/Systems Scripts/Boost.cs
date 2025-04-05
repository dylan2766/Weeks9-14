using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boost : MonoBehaviour
{
    public SpawnerA spawnerA;
    public SpawnerA spawnerS;
    public SpawnerA spawnerD;

    public Image image;
    public Color colour;

    public void IsOn()
    {
        colour.a = 0.2f;
        image.color = colour;

        spawnerA.speed = spawnerA.speed / 2;
        spawnerS.speed = spawnerS.speed / 2;
        spawnerD.speed = spawnerD.speed / 2;
    }

    public void IsOff()
    {
        colour.a = 0.8f;
        image.color = colour;

        spawnerA.speed = spawnerA.speed * 2;
        spawnerS.speed = spawnerS.speed * 2;
        spawnerD.speed = spawnerD.speed * 2;
    }
}
