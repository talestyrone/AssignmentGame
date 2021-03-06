﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalRight : MonoBehaviour
{
    public Text leftScore;
    public int startLeft = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       leftScore.text = "" + Scores.leftScore;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        startLeft++;
        Scores.leftScore++;
        if (Scores.leftScore == 2 && Scores.currentLevel == 1)
        {
            SceneManager.LoadScene(sceneName: "lvl2");
            startLeft = 0;
            Scores.leftScore = 0;
            leftScore.text = "" + leftScore;
            Scores.currentLevel++;

            System.Threading.Thread.Sleep(100);
        }

        if (Scores.leftScore == 2 && Scores.currentLevel == 2)
        {
            SceneManager.LoadScene(sceneName: "lvl3");
            startLeft = 0;
            Scores.currentLevel++;
            System.Threading.Thread.Sleep(100);
        }
    }
}