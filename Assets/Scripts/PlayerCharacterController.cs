using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using static GameManager;


public class PlayerCharacterController : ThirdPersonController
{

    [SerializeField] private GameManager gameManager;


    private void OnPause(InputValue value)
    {
        if (value.isPressed)
        {

           gameManager.TogglePause();            

        }

    }

    private void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Removed item");
            GetComponent<Inventory>().RemoveItemFromInventory();


        }
    }
}
