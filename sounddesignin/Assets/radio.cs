using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{
    public int zvuk;
    private AudioSource AC;
    void Start()
    {
        AC = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnMouseDown()
    {
        zvuk += 1;
        if (zvuk % 2 == 1)
        {
            AC.Pause();
        }
        else
        {
            AC.Play();
        }
    }
}
