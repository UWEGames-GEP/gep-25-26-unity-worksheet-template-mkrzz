using UnityEngine;
using System.Collections.Generic;
using System;




public class Inventory : MonoBehaviour
{
    public GameManager gameManager;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Item collisionItem = hit.collider.gameObject.GetComponent<Item>();

        if (collisionItem != null )
        {
            items.Add(collisionItem.name);
        }

       
        
            Destroy(collisionItem.gameObject);
        
    }

    

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    public List<string> items = new List<string>();
    string itemName;
   
       
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
