using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(" You Get Key !! ");
        Destroy(gameObject);

        PlayerController player = GameObject.FindObjectOfType<PlayerController>();
        player.Addkey();
        
        
       
       








    }
}