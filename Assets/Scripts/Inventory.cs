using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;




public class Inventory : MonoBehaviour
{

    public GameManager gameManager;
    public List<Item> items = new List<Item>();
    AudioSource audioSource;



    void OnControllerColliderHit(ControllerColliderHit hit)
    {


        Item collisionItem = hit.gameObject.GetComponent<Item>();

        if (collisionItem != null)
        {


            items.Add(collisionItem);
            /*audioSource.Play();*/
            collisionItem.gameObject.SetActive(false);
            /*Destroy(collisionItem.gameObject);*/
            



        }


    }


    void Start()
    {
        
        gameManager = FindAnyObjectByType<GameManager>();


    }




    /*public void Add(string itemName)
    {

        items.Add(Item);

    }

    public void Remove(string itemName)
    {

        items.Remove(itemName);

    }*/




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

}
