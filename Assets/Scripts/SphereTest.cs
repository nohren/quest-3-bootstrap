using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class SphereTest : MonoBehaviour
{
    public float speedFactor;
    public Color startColor, endColor;
    private Renderer renderer;
    private Color lerpedColor;

    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }
    
    void Update()
    {
       lerpedColor = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speedFactor, 1));
       renderer.material.color = lerpedColor;
    }
}
