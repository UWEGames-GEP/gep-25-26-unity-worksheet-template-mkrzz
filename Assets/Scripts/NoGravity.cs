using System.Collections;
using UnityEngine;

public class NoGravity : MonoBehaviour
{

    [SerializeField] private float gravity = -15f;
    [SerializeField] private float noGravity = 0f;
    [SerializeField] private float duration = 5f;


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


    private IEnumerator BoostRoutine(PlayerCharacterController playerCharacterController)
    {

        gravity = playerCharacterController.Gravity;
        playerCharacterController.Gravity = noGravity;
        yield return new WaitForSeconds(duration);
        playerCharacterController.Gravity = gravity;


    }
}


