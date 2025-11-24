using UnityEngine;
using UnityEngine.Audio;

public class Item : MonoBehaviour
{

    private SphereCollider itemCollider;
    private MeshRenderer mr;
    public string itemName;
    public string itemDescription;
    public AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCollider = GetComponent<SphereCollider>();
        mr = GetComponent<MeshRenderer>();

    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Inventory inv = other.GetComponent<Inventory>();

            if (inv != null)
            {
                inv.Add(itemName);   
            }

            audioSource.Play();
            itemCollider.enabled = false;
            mr.enabled = false;
            

        }
    }


    

}
