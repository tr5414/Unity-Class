using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpotlightScript : MonoBehaviour
{
    public bool on = false;
    public Light light;
    void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            on = !on;
        if (on)
            light.enabled = true;
        else if (!on)
            light.enabled = false;
    }
}