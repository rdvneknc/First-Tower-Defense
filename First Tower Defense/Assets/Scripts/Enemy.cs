using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavePoint = 0;

    
    void Start()
    {
        target = Waypoints.wayPoints[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        //Reminder: .normalized >> Vector'de direction ve magnitude bulunur. normalized kullanýldýðýnda magnitude gider, yalnýzca direction kalýr. Detaylara bak

        if(Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            NextWayPoint();
        }
        
    }

    void NextWayPoint()
    {
        if(wavePoint >= Waypoints.wayPoints.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        
        wavePoint++;
        target = Waypoints.wayPoints[wavePoint];
    }
}
