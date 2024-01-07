using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTest : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer renderer;
    private int rgb = 0;

    void ChangeColor()
    {
        Color c = renderer.material.color;
        c.r = rgb;
        c.g = 255 - rgb;
        c.b = 255 / (rgb + 1);
        renderer.material.color = c;
        int next = rgb += 1;
        rgb = next > 255 ? 0: next;
    }

    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       ChangeColor();
    }
}
