using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour {

    // Use this for initialization
    float timer = 0;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            SceneManager.LoadScene("Level2");
        }
    }
}
