using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFactory : MonoBehaviour
{
    public IFruit GetFruit(FruitType type)
    {
        switch (type)
        {
            case FruitType.Banana:
                IFruit banana = new Banana();
                return banana;
            case FruitType.Cherry:
                IFruit cherry = new Cherry();
                return cherry;
            case FruitType.Cheese:
                IFruit cheese = new Cheese();
                return cheese;
        }
        return null;
    }
}
