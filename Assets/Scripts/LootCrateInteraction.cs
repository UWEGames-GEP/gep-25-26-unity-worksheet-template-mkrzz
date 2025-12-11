using UnityEngine;
using TMPro;

public class LootCrateInteraction : MonoBehaviour
{
    public LootCrateUI lootCrateUI;
    private bool playerInRange;
    public TextMeshProUGUI interactionHint;
    private Camera mainCamera;
    public Vector3 hintOffset = new Vector3(0, 1f, 0);


    void Start()
    {
        mainCamera = Camera.main;
    }


    void Update()
    {

        // Follow the crate
        if (interactionHint.gameObject.activeSelf)
        {
            Vector3 screenPos = mainCamera.WorldToScreenPoint(transform.position + hintOffset);
            interactionHint.transform.position = screenPos;
        }

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

        if (interactionHint != null)
            interactionHint.gameObject.SetActive(true);

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = false;
            lootCrateUI.Hide();
            if (interactionHint != null)
                interactionHint.gameObject.SetActive(false);

        }
    }


}
