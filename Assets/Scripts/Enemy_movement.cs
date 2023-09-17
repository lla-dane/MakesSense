using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Pathfinding;

public class Enemy_movement : MonoBehaviour
{
    public Detection_system detection_System;
    [SerializeField] public Waypoints waypoints;
    private float velocity = 5f;
    private Transform currentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }
    // Update is called once per frame
    void Update()
    {
        if (!detection_System.PlayerInArea)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, velocity * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }

    }


}
