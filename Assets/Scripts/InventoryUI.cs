using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Transform inventoryPanel;
    public GameObject slotPrefab;
    public Inventory inventory;

    void Start()
    {
        inventory.onInventoryChanged += RefreshUI;
        RefreshUI();
    }

    public void RefreshUI()
    {

        //removes slot from inventory
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // adds a new slot for item
        foreach (var item in inventory.items)
        {
            GameObject slot = Instantiate(slotPrefab, inventoryPanel);

            //Confirms correct scale of image
            slot.transform.localScale = Vector3.one;

            //assigns the icon
            Image icon = slot.transform.Find("ItemIcon").GetComponent<Image>();
            icon.sprite = item.itemIcon;

        }


    }


}
