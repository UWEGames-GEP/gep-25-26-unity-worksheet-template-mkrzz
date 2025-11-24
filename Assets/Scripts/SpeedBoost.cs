using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class SpeedBoost : MonoBehaviour
{
    
    private float defaultSpeed;
    private float defaultSprintSpeed;
    public float boostedSpeed = 10f;
    public float boostedSprintSpeed = 10f;
    public float duration = .005f;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            ThirdPersonController thirdPersonController = other.GetComponent<ThirdPersonController>();


            if (thirdPersonController)
            {

                StartCoroutine(BoostRoutine(thirdPersonController));

            }

        }

    }


    // stores the default speed and sprint speed from the 3rd person script
    // applies new speeds
    // resets back to default speeds

    private IEnumerator BoostRoutine(ThirdPersonController thirdPersonController)
    {
        defaultSprintSpeed = thirdPersonController.SprintSpeed;
        defaultSpeed = thirdPersonController.MoveSpeed;

        thirdPersonController.MoveSpeed = boostedSpeed;
        thirdPersonController.SprintSpeed = boostedSprintSpeed;

        yield return new WaitForSeconds(duration);

        thirdPersonController.MoveSpeed = defaultSpeed;
        thirdPersonController.SprintSpeed = defaultSprintSpeed;

    }




}
