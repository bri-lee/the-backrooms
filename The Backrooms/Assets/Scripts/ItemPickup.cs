using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItemData referenceItem;
    public GameObject item;
    public GameObject player;

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

    void FixedUpdate()
    {
        RaycastHit hit;

        // get vector3 for where player is looking
        Vector3 direction = Vector3.forward;

        if (Input.GetKey("e"))
        {
            Debug.Log("e pressed");

            if (Physics.Raycast(player.transform.position, player.transform.TransformDirection(direction), out hit, 8))
            {
                Debug.DrawRay(player.transform.position, player.transform.TransformDirection(direction) * hit.distance, Color.red);
                Debug.Log("Hit object");

                OnHandlePickupItem();
            }
            else
            {
                Debug.Log("Did not hit");
            }

        }
    }
}
