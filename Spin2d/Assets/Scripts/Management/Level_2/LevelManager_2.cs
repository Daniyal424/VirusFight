using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_2 : MonoBehaviour
{
    public bool gameHasEnded = false;
    public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameHasEnded == true)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverScreen.SetActive(true);


    }
}
