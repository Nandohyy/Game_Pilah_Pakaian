﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    float timer = 0;
    
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            SceneManager.LoadScene("MenuLevel2");
            //MediaGameOverMusic.Play();
        }
	}
}
