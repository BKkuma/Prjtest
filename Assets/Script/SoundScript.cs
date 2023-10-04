using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //[SerializeField] private AudioClip m_Clip;
    [SerializeField] private SoundLibrary  soundLibrary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint (soundLibrary.Coinsound, transform.position);
        AudioSource.PlayClipAtPoint(soundLibrary.BGMsound, transform.position);

    }
}
