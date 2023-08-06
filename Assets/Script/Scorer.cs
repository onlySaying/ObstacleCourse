using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            hits++;
            ObjectHit oh = collision.gameObject.GetComponent<ObjectHit>();
            if(oh != null)
            {
                Debug.Log("You've bumped into a things this many times : " + hits);
            }
        }
        
    }
}
