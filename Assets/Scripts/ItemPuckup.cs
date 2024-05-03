using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPuckup : MonoBehaviour
{

    public Item Item;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    private void OnTouchDown()
    {
        Pickup();
    }
}
