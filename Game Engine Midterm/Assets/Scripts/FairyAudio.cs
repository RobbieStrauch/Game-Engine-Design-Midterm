using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyAudio : MonoBehaviour
{
    AudioSource audio;
    AudioController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = AudioController.instance;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isFairyHit && Input.GetKey(KeyCode.E))
        {
            ChangeSpeed(2);
        }
        else
        {
            ChangeSpeed(1);
        }
    }

    public void ChangeSpeed(float value)
    {
        audio.pitch = value;
    }
}
