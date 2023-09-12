using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
           { 
            Debug.Log(" you take point");
            Destroy(gameObject, 1f);

            PlayerController player =  GameObject.FindObjectOfType<PlayerController>();
            player.Addscore();
            
           
        }

    }
}
