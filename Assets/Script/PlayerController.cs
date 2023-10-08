using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;
    private Rigidbody rg2d;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private SoundLibrary soundLibrary;


    // Start is called before the first frame update
    private void Start()
    {
        rg2d = GetComponent<Rigidbody>();
        
        

    }

    // Update is called once per frame
    private void Update()
    {
        float x = 0.0f;
        float y = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = -rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            y = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            y = -rotationSpeed * Time.deltaTime;
        }
        rg2d.AddTorque(0, 0, x);
        rg2d.AddTorque(y, 0, 0);
        
    }
    public void Addscore()
    {
        playerData.score = playerData.score + 1;

        AudioSource.PlayClipAtPoint (soundLibrary.Coinsound,transform.position);
        
    }
    public void Addkey()
    {
        playerData.key = playerData.key + 1;
        if (playerData.key == 3)
        {
            SceneManager.LoadScene(1);
            playerData.key++;
            
        }
       
    }
    public int GetScore()
    {
        return playerData.score;

    }
    public int GetKey()
    {
        return playerData.key;
    }
   
    
} 
