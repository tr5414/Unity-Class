using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xpos: MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(Pos);
    }
}
