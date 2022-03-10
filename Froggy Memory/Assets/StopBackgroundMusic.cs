using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    public AudioSource BackgroundMusic;

    // Update is called once per frame
    void Update()
    {
        BackgroundMusic.Stop();
    }
}
