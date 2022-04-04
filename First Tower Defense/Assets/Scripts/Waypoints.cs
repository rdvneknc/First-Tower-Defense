using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] wayPoints;


    private void Awake()
    {
        wayPoints = new Transform[transform.childCount];

        for (int i = 0; i < wayPoints.Length; i++)
        {
            wayPoints[i] = transform.GetChild(i);
        }
        //Reminder: bu objede 13 child var, arrayde 13 yer a�. bu 13 child�n tamam�n� loop et
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
