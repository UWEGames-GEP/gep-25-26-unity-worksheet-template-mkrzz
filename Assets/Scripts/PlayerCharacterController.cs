using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using static GameManager;

public class PlayerCharacterController : ThirdPersonController
{
    private void OnPause(InputValue value)
    {
        if (value.isPressed)
        {

            Debug.Log("Pause game");
        }


    }
}
