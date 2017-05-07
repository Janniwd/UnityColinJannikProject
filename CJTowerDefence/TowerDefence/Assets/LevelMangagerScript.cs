using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMangagerScript : MonoBehaviour {
    
    public static Transform[] WayPoints;

    void Awake()
    {
        WayPoints = new Transform[transform.childCount];
        for (int i = 0; i < WayPoints.Length; i++)
        {
            WayPoints[i] = transform.GetChild(i).transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
