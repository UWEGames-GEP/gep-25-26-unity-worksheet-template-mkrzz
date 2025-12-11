using UnityEngine;
using TMPro;

public class LootCrateInteraction : MonoBehaviour
{
    public LootCrateUI lootCrateUI;
    private bool playerInRange;
    public GameObject pressEText;





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

        if (pressEText != null)
            pressEText.SetActive(true);



    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = false;
            lootCrateUI.Hide();

            if (pressEText != null)
                pressEText.SetActive(false);

        }
    }


}
