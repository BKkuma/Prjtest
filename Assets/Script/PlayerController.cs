using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;
    [SerializeField] private int Score = 0;
    [SerializeField] private int Key = 0;
    private Rigidbody rg2d;


    // Start is called before the first frame update
    private void Start()
    {
        rg2d= GetComponent<Rigidbody>();
            
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
        Score = Score + 1;
    }
    public void Addkey()
    {
        Key = Key + 1; 
        if (Key== 3) 
        {
            SceneManager.LoadScene(0);
        }
    }
    public int GetScore()
    {
        return Score;
    }
   
}
