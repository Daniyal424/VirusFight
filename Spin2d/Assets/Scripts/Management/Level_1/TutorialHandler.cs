using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public bool TutorialFinished = false;
    public static TutorialHandler Instance ;

    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
                
            else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
