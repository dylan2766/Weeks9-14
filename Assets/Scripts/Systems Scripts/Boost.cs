using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boost : MonoBehaviour
{
    //variables
    public SpawnerA spawnerA;
    public SpawnerA spawnerS;
    public SpawnerA spawnerD;

    public Image image;
    public Color colour;
    public Timer time;

    //if boost is enabled change the opacity to 20% and change the boost time to 1.5 making the timer drain faster and set the spawn speed of notes to be doubled
    public void IsOn()
    {
        colour.a = 0.2f;
        image.color = colour;
        time.boost = 1.5f;

        spawnerA.speed = spawnerA.speed / 2;
        spawnerS.speed = spawnerS.speed / 2;
        spawnerD.speed = spawnerD.speed / 2;
    }

    //if boost is off change the opacity to more 80% and change boost speed to 1 and reset the spawn note speed to default
    public void IsOff()
    {
        colour.a = 0.8f;
        image.color = colour;
        time.boost = 1;

        spawnerA.speed = spawnerA.speed * 2;
        spawnerS.speed = spawnerS.speed * 2;
        spawnerD.speed = spawnerD.speed * 2;
    }
}
