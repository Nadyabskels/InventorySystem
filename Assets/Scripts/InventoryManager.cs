using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
      Items.Add(item);
    }

       public void Remove(Item item)
    {
        Items.Remove(item);

    }
}
//st ab 6:00
//6:22
