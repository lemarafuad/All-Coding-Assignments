using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in items)
            {
                Debug.Log(item);
            }
        }
        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory combinedInventory = new Inventory();
            foreach (string item in a.items)
            {
                combinedInventory.AddItem(item);
            }
            foreach (string item in b.items)
            {
                combinedInventory.AddItem(item);
            }
            return combinedInventory;
        }
    }
}