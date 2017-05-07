using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float speed = 1000f;
    private Transform WayPointTransform;
    private int WayPointIndex = 0;

    void Start()
    {
        WayPointTransform = LevelMangagerScript.WayPoints[0];
    }

    void Update()
    {
        Vector3 ToMove = WayPointTransform.position - transform.position;
        transform.Translate(ToMove.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, WayPointTransform.position) <= 0.2f)
        {
            GetNewWayPoint();
        }
    }

    void GetNewWayPoint()
    {
        if (WayPointIndex == LevelMangagerScript.WayPoints.Length - 1)
        {
            Debug.Log("Finish");
        }
        WayPointIndex++;
        WayPointTransform = LevelMangagerScript.WayPoints[WayPointIndex];
    }
}
