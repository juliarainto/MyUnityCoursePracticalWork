﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text EndText;

    void Start()
    {
        EndText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        EndText.text = "Game Over!";
    }
}
