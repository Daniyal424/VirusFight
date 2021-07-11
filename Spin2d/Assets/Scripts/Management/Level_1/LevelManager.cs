using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool gameHasEnded = false;
    public bool GameRestarted = false;
    public GameObject GameOverScreen;
    public GameObject TD;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    private int TutorialCount = 0;
  
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (GameObject.Find("TutorialHandler").GetComponent<TutorialHandler>().TutorialFinished == false)
        {
            Time.timeScale = 0f;
            Debug.Log("tutorial");
           
        }
        else
        {
            Destroy(TD);
            GameRestarted = true;
            Time.timeScale = 1;
        }
        
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverScreen.SetActive(true);


    }
    public void Tutorial()
    {
      
       
    }
    void Start()
    {
     
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GameRestarted == false)
        {
            TutorialCount += 1;
        }
        if (TutorialCount == 1)
        {
            T1.SetActive(false);
            T2.SetActive(true);
        }
        if (TutorialCount == 2)
        {
            T2.SetActive(false);
            T3.SetActive(true);
        }
        if (TutorialCount == 3)
        {
            T3.SetActive(false);
            T4.SetActive(true);
        }
        if (TutorialCount == 4)
        {
            TD.SetActive(false);
            Time.timeScale = 1;
            GameObject.Find("TutorialHandler").GetComponent<TutorialHandler>().TutorialFinished = true;
        }
        if (gameHasEnded == true)
        {
            GameOver();
        }
    }
}
