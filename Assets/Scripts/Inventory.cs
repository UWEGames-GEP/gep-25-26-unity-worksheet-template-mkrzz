using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;




public class Inventory : MonoBehaviour
{

    public GameManager gameManager;
    public List<string> items = new List<string>();
    AudioSource audioSource;



    /*void OnControllerColliderHit(ControllerColliderHit hit)
    {


        Item collisionItem = hit.gameObject.GetComponent<Item>();

        if (collisionItem != null)
        {


            items.Add(collisionItem.name);
            audioSource.Play();
            collisionItem.gameObject.SetActive(false);
            


        }


    }*/


    void Start()
    {
        
        gameManager = FindAnyObjectByType<GameManager>();


    }

  
   
       
    public void Add(string itemName)
    {

        items.Add(itemName);
        
    }

    public void Remove(string itemName)
    {

        items.Remove(itemName);
        
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


    private void AddItemToInventory(string v)
    {

        Add(v);
                
    }

    private void RemoveItemFromInventory(string v)
    {
     
        Remove(v);
        
    }

}
