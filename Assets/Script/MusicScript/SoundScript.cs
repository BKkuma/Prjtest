using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //[SerializeField] private AudioClip m_Clip;
    [SerializeField] private SoundLibrary  soundLibrary;
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(soundLibrary.Coinsound, transform.position);
        AudioSource.PlayClipAtPoint(soundLibrary.BGMsoundlevel1and2, transform.position);
        AudioSource.PlayClipAtPoint(soundLibrary.BGMmenusound, transform.position);
        AudioSource.PlayClipAtPoint(soundLibrary.Keysound, transform.position);

    }
}
