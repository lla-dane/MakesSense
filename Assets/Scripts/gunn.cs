using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunn : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            panel.SetActive(true);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            panel.SetActive(false);
        }
    }
}
