using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");
            Debug.Log(gameContainer.GetItem());
            Debug.Log(GameUtils.DescribeItem(gameContainer.GetItem()));
            // Try another type ... :)
            GameContainer<int> gameContainer1 = new GameContainer<int>();
            gameContainer1.SetItem(10);
            Debug.Log(gameContainer1.GetItem());
            Debug.Log(GameUtils.DescribeItem(gameContainer1.GetItem()));
        }
    }
}