using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    public bool isFairyHit;
    public bool isFairyActivated;

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }

        isFairyHit = false;
        isFairyActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
