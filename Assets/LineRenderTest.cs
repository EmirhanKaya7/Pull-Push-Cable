using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderTest : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    [SerializeField] private LineRnderer line;
    
void Start()    
    {
        line.setLine(points);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
