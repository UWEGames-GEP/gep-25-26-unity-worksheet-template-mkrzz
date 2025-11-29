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
}
