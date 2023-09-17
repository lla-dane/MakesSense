using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection_system : MonoBehaviour
{
    public bool PlayerInArea = false, drawGizmos = true;
    private int sus_value =0;
    public float waiting_time;
    [SerializeField] public suspicion sus;
    [SerializeField] public ToggleColorChange invisibility;
    [SerializeField] public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Mycoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < 2f){
            PlayerInArea = true;
            // Debug.Log("ABcd");
        }
        else{
            PlayerInArea = false;
        }
    }

    private void OnDrawGizmos(){
        if(drawGizmos && !PlayerInArea){
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, 2);
        }
        if(drawGizmos && PlayerInArea){
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, 2);
        }
    }

    IEnumerator Mycoroutine(){
        // Debug.Log("start_routine");
        if(PlayerInArea && sus_value < 100 && !invisibility.colorChanged){
            sus_value += 10;
        }
        if((!PlayerInArea || invisibility.colorChanged) && sus_value > 0){
            sus_value -= 5;
        }
        sus.Setsuspicion(sus_value);
        yield return new WaitForSeconds(waiting_time);
        StartCoroutine(Mycoroutine());
    }
}
