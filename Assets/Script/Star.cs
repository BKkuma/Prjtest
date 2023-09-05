using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
           { 
            Debug.Log(" you take 100 point");
            Destroy(gameObject, 1f);

           }
        
    }
}
