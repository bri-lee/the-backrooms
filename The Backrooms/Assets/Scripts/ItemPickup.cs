using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItemData referenceItem;
    public GameObject item;

    public void OnHandlePickupItem()
    {
        InventoryHandler.current.Add(referenceItem);
        Destroy(item);
    }

    // Test for when touching object it picks up, will implement pickup buttons later
    // Maybe look into using raycasting for this.
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OnHandlePickupItem();
        }
    }
}
