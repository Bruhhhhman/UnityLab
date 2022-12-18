using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    private AudioSource Sig;

 
    void Start()
    {
        Sig = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    public void signal()
    {
        Sig.Play();
    }
}
