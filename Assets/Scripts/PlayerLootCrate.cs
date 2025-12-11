using UnityEngine;

public class PlayerLootCrate : MonoBehaviour
{


    public Inventory playerInventory;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Item item = hit.gameObject.GetComponent<Item>();
        if (item != null)
        {
            playerInventory.AddItemToInventory(item);
            item.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(item.pickupSound, item.transform.position);
        }
    }


}
