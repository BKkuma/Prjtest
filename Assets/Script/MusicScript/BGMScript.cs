using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour
{
    [SerializeField] private SoundLibrary SoundLibrarysoundLibrary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.PlayClipAtPoint(SoundLibrarysoundLibrary.BGMsound, transform.position);
    }
}
