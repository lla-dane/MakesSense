using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempickup : MonoBehaviour
{
    public Item Item;
    void Pickup(){
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);

    }

    private void  OnTriggerEnter2D(Collider2D collider){
        Pickup();
    }
    
    
}
