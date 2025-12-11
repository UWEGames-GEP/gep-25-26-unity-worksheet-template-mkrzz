using UnityEngine;
using UnityEngine.Audio;

public class Item : MonoBehaviour
{

    
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    public AudioClip pickupSound;
    public Sprite itemIcon;

    // accessible by other scripts if referencing below
    public string ItemName => itemName;
    public string ItemDescription => itemDescription;
    public AudioClip PickupSound => pickupSound;
    public Sprite ItemIcon => itemIcon;



    /*void Start()
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

    }*/




}
