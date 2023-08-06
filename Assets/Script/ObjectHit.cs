using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Mover mover = collision.gameObject.GetComponent<Mover>();
            if(mover != null)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                gameObject.tag = "Hit";
            }
        }
        
    }
}
