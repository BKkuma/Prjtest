using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private  PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        //text = GetComponent<TMP_Text>();
        //player = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = player.GetScore().ToString();

    }
}
