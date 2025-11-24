using UnityEngine;
using UnityEngine.Audio;

public class Item : MonoBehaviour
{

    private Collider itemCollider;
    private MeshRenderer mr;

    public string itemName;
    public string itemDescription;
    public AudioSource audioSource;


    void Start()
    {

        //looks for these components on the game object
        audioSource = GetComponent<AudioSource>();
        itemCollider = GetComponent<Collider>();
        mr = GetComponent<MeshRenderer>();

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            Inventory inv = other.GetComponent<Inventory>();

            if (inv != null)
            {
                inv.Add(itemName);
            }

            audioSource.Play();

            //disables the collider and mesh renderer 
            itemCollider.enabled = false;
            mr.enabled = false;


        }

    }




}
