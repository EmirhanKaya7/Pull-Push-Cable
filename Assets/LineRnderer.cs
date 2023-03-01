using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRnderer : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void setLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i<points.Length ; i++)
        {
            lr.SetPosition(i,points[i].position);
        }
    }
}
