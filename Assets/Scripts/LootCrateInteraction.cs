using UnityEngine;

public class LootCrateInteraction : MonoBehaviour
{
    public LootCrateUI lootCrateUI;
    private bool playerInRange;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!lootCrateUI.IsVisible())
            {
                lootCrateUI.Show();
            }
            else
            {
                lootCrateUI.TakeNextItem();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            lootCrateUI.Hide();
        }
    }


}
