using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> inventory;

    public void AddObjectoToInventory(GameObject item)
    {
        inventory.Add(item);
    }

    public void RemoveObjectFromInventory(GameObject item)
    {
        inventory.Remove(item);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            AddObjectoToInventory(other.gameObject);
        }
    }
}
