﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableCoffeeCup : MonoBehaviour
{
    private bool isClickable = true;

    private void OnMouseDown()
    {
        if (isClickable)
        {
            // Set the flag to indicate we are transitioning to another scene
            PlayerPrefs.SetInt("ReturningFromScene2", 1);

            // Load Scene2
            SceneManager.LoadScene("CoffeeMiniGameScene");
        }
    }

    public void SetClickable(bool clickable)
    {
        isClickable = clickable;
    }
}
