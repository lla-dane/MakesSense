using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{
    public Transform nextRoom;
    public Transform playerPosition;

    void Start()
    {
        
    }

   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.tag=="Player")
        {
           playerPosition=nextRoom;
        }

   }
}
