using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HexagonSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Button buttonToChangeColour;

    public void Spawn()
    {
        GameObject newHexagon = Instantiate(prefab, Random.insideUnitCircle * 4, transform.rotation);
        Hexagon hexagon = newHexagon.GetComponent<Hexagon>();

        buttonToChangeColour.onClick.AddListener(hexagon.ChangeColour);
    }

    public void StopListening()
    {
        buttonToChangeColour.onClick.RemoveAllListeners();
    }
}
