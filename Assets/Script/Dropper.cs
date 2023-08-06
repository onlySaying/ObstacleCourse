using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timetoDrop = 5f;
    MeshRenderer meshRenderer;
    Rigidbody rb;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timetoDrop)
        {
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
