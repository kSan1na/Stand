using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieInclide : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public int speedconv;
    public Material mt;
    public Material mt2;


    // Update is called once per frame
    void FixedUpdate()
    {
        mt.mainTextureOffset = new Vector2(0f, Time.time * speedconv * Time.deltaTime);
        Vector3 pos = rb.position;
        rb.position += Vector3.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);

    }

}   
