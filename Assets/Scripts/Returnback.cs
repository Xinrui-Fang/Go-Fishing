﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returnback : MonoBehaviour
{
    public void Return ()
    {
        SceneManager.LoadScene("Menu");
    }
}
