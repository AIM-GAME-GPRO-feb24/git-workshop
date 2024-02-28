using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miauw : MonoBehaviour
{

    public AudioSource someSound;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            someSound.Play();
        }
    }
}
