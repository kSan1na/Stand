using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckerPlatformMoving : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 startpos;
    private float speed=0.1F;
    public float minY;
    public float maxY;
    void Start()
    {
        Vector3 startpos = rb.position;
        maxY = startpos[1] + 0.15F;
        minY = startpos[1] - 1.0F;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = rb.position;
        if (pos[1] < maxY) {
            while(pos[1]<maxY){
                rb.position += Vector3.up * speed * Time.fixedDeltaTime; }
        }
        if (pos[1] > minY)
        {
            rb.position += Vector3.up * (-1F)*speed * Time.fixedDeltaTime;
        }
    }
}
