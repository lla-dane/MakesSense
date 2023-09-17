using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake(){
        Instance = this;
    }
    public void Add(Item item){
        Items.Add(item);    
    }
    public void ListItems(){
        // Cleans content before opening
        foreach(Transform item in ItemContent){
            Destroy(item.gameObject);
        }
        foreach(var Item in Items){ 
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            
            itemName.text = Item.itemName;
            itemIcon.sprite = Item.icon;
        }
    }

}
