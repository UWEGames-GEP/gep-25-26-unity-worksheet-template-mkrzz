using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LootCrateUI : MonoBehaviour
{
    public Inventory crateInventory;
    public Inventory playerInventory;

    public GameObject panel;
    public Transform itemListParent;
    public GameObject itemButtonPrefab;


    void Start()
    {
        Hide();
    }

    public void Show()
    {

        panel.SetActive(true);
        RefreshUI();

    }


    void Update()
    {

    }

    public void Hide()
    {

        panel.SetActive(false);

    }

    public void RefreshUI()
    {

        // destroys previous items
        foreach (Transform child in itemListParent)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < crateInventory.items.Count; i++)
        {
            Item item = crateInventory.items[i];

            // Instantiate the slot prefab and parent it properly

            GameObject slot = Instantiate(itemButtonPrefab, itemListParent);
            slot.transform.SetParent(itemListParent, false); 
            slot.transform.localScale = Vector3.one;

            // Assign the icon
            Image icon = slot.transform.Find("ItemIcon")?.GetComponent<Image>();
            if (icon != null)
                icon.sprite = item.itemIcon;

            
            TMP_Text nameText = slot.transform.Find("ItemName")?.GetComponent<TMP_Text>();
            if (nameText != null)
                nameText.text = item.ItemName;

            
        }


    }

    public void TakeItem(int index)
    {

        Item item = crateInventory.items[index];

        // player gets item 
        crateInventory.RemoveItemFromInventory(item);
        playerInventory.AddItemToInventory(item);

        // update UI
        RefreshUI(); 

    }

    internal bool IsVisible()
    {
        return panel.activeSelf;
    }

    internal void TakeNextItem()
    {
        if(crateInventory.items.Count == 0) return;

        int lastIndex = crateInventory.items.Count - 1;
        Item item = crateInventory.items[lastIndex];

        crateInventory.RemoveItemFromInventory(item);
        playerInventory.AddItemToInventory(item);

        // Tell player inventory UI to update
        playerInventory.onInventoryChanged?.Invoke();

        RefreshUI(); // update crate UI
    }
}