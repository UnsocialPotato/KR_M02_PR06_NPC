using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClient : MonoBehaviour
{
    public FruitSpawner m_SpawnerFruit;
    public GameObject BananaPun;
    public GameObject CherryPun;
    public GameObject CheesePun;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            m_SpawnerFruit.SpawnBanana();
            BananaPun.SetActive(!BananaPun.activeInHierarchy);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            m_SpawnerFruit.SpawnCherry();
            CherryPun.SetActive(!CherryPun.activeInHierarchy);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            m_SpawnerFruit.SpawnCheese();
            CheesePun.SetActive(!CheesePun.activeInHierarchy);
        }
    }
}
