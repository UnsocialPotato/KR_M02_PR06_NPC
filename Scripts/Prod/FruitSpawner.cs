using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSpawner : MonoBehaviour
{
    public FruitFactory m_Factory;

    private IFruit m_Banana;
    private IFruit m_Cherry;
    private IFruit m_Cheese;


    public void SpawnBanana()
    {
        m_Banana = m_Factory.GetFruit(FruitType.Banana);
        
        m_Banana.Speak();
    }

    public void SpawnCherry()
    {
        m_Cherry = m_Factory.GetFruit(FruitType.Cherry);

        m_Cherry.Speak();
    }

    public void SpawnCheese()
    {
        m_Cheese = m_Factory.GetFruit(FruitType.Cheese);

        m_Cheese.Speak();
    }
}
