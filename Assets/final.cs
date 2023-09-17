using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public GameObject final_Cutscene;

    // Start is called before the first frame update
    void Start()
    {
        final_Cutscene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            final_Cutscene.SetActive(true);
        }
    }
}
