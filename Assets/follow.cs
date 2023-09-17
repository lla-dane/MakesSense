using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour
{

    public Transform player; // this is to get the transform component of the player gameobject
    Vector3 temp; // temp will be used to store the position of the player in the temporary vector

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //here you have to update the position of the camera which will be equal to that of player but be carefull about the z direction 
        if (player)
            transform.position = new Vector3(player.position.x +11, player.position.y+4, -10);
    }
}
