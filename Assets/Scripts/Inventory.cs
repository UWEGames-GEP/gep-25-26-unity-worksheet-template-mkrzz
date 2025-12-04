using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;




public class Inventory : MonoBehaviour
{

    GameManager gameManager;   
   /* public AudioSource audioSource;*/
    Transform worldItemsTransform;

    public List<Item> items = new List<Item>();
    

    void OnControllerColliderHit(ControllerColliderHit hit)
    {


        Item collisionItem = hit.gameObject.GetComponent<Item>();

        if (collisionItem != null)
        {

            
            items.Add(collisionItem);
            collisionItem.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(collisionItem.pickupSound, collisionItem.transform.position);

           /* audioSource.PlayOneShot(collisionItem.pickupSound);*/
            /*Destroy(collisionItem.gameObject);*/
            /*audioSource.Play();*/




        }


    }


    void Start()
    {
        
        gameManager = FindAnyObjectByType<GameManager>();
        Transform worldItemsTransform = GameObject.Find("WorldItems").transform;

    }




    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            AddItemToInventory("Generic Item");
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            RemoveItemFromInventory("Generic Item");            

        }*/
    }


    public void AddItemToInventory(Item item)
    {

        items.Add(item);
                
    }

    public void RemoveItemFromInventory(Item item)
    {

        items.Remove(item);
        
    }

    public void RemoveItemFromInventory()
    {

        // Check that we can remove item from inventory
        if (gameManager.currentState is GameplayState && items.Count > 0)
        {

            // Store the item at the top of the list as a variable
            Item item = items[0];

            // Get the properties for where we want to spawn 
            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 100, 0);

            // Instantiate a copy of the held item
            GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, worldItemsTransform);
            newItem.SetActive(true);

            // Clean up exisiting item 
            items.Remove(item);
            Destroy(item.gameObject);
            /*item.gameObject.SetActive(false);*/
        }
    }

}
