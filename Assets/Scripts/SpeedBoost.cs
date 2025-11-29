using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class SpeedBoost : MonoBehaviour
{
    
    private float defaultSpeed;
    private float defaultSprintSpeed;

    public float boostedSpeed = 15f;
    public float boostedSprintSpeed = 15f;
    public float duration = 1f;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            PlayerCharacterController playerCharacterController = other.GetComponent<PlayerCharacterController>();


            if (playerCharacterController)
            {

                StartCoroutine(BoostRoutine(playerCharacterController));

            }

        }

    }


    // stores the default speed and sprint speed from the 3rd person script
    // applies new speeds
    // resets back to default speeds

    private IEnumerator BoostRoutine(PlayerCharacterController playerCharacterController)
    {

        defaultSprintSpeed = playerCharacterController.SprintSpeed;
        defaultSpeed = playerCharacterController.MoveSpeed;

        playerCharacterController.MoveSpeed = boostedSpeed;
        playerCharacterController.SprintSpeed = boostedSprintSpeed;

        yield return new WaitForSeconds(duration);

        playerCharacterController.MoveSpeed = defaultSpeed;
        playerCharacterController.SprintSpeed = defaultSprintSpeed;

    }




}
