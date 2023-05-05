using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Create a dictionary to store items in the inventory
    private Dictionary<string, int> inventory;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the inventory dictionary
        inventory = new Dictionary<string, int>();
    }

    // Add an item to the inventory
    public void AddItem(string itemName, int quantity)
    {
        // Check if the item already exists in the inventory
        if (inventory.ContainsKey(itemName))
        {
            // If the item already exists, add the quantity to the existing quantity
            inventory[itemName] += quantity;
        }
        else
        {
            // If the item doesn't exist, add it to the inventory with the specified quantity
            inventory.Add(itemName, quantity);
        }
    }

    // Remove an item from the inventory
    public void RemoveItem(string itemName, int quantity)
    {
        // Check if the item exists in the inventory
        if (inventory.ContainsKey(itemName))
        {
            // If the item exists, subtract the quantity from the existing quantity
            inventory[itemName] -= quantity;

            // Check if the quantity is zero or less, and remove the item from the inventory if it is
            if (inventory[itemName] <= 0)
            {
                inventory.Remove(itemName);
            }
        }
    }

    // Check if the inventory contains a certain item
    public bool HasItem(string itemName)
    {
        return inventory.ContainsKey(itemName);
    }

    // Get the quantity of a certain item in the inventory
    public int GetQuantity(string itemName)
    {
        // Check if the item exists in the inventory
        if (inventory.ContainsKey(itemName))
        {
            // If the item exists, return the quantity
            return inventory[itemName];
        }
        else
        {
            // If the item doesn't exist, return zero
            return 0;
        }
    }
}
