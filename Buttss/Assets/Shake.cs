using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake: MonoBehaviour
{
    Vector3 position;
    public float speed = 1.0f; //how fast it shakes
    public float amount = 1.0f; //how much it shakes

    void Update()
    {
        position = transform.position;
        position.x = Mathf.Sin(Time.time * speed) * amount;
        transform.position = position;
    }
}