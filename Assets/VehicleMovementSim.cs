using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovementSim : MonoBehaviour
{
    float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zz = transform.position.z;
        zz += speed;
        transform.position = new Vector3(transform.position.x, transform.position.y, zz);   
    }
}
