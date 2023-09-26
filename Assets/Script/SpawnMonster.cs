using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U)) 
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(spawnObject,transform.position, transform.rotation);
    }
}
