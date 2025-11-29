using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class SpeedBoost : MonoBehaviour
{

    [SerializeField] private float defaultSpeed;
    [SerializeField] private float defaultSprintSpeed;

    [SerializeField] private float boostedSpeed = 15f;
    [SerializeField] private float boostedSprintSpeed = 15f;
    [SerializeField] private float duration = 1f;

    [SerializeField] private AudioSource audioSource;


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

        audioSource.Play();

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
