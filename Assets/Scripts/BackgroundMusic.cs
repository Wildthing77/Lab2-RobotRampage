﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);// allows the music to continue playing after you start the game
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
