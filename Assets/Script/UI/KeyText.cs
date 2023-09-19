using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;   
    [SerializeField] private PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerData.key.ToString();
    }
}
