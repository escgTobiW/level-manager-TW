using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    private int highScore;

    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            //print("dont destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            //print("do destroy");
            Destroy(gameObject);
        }
    }


    //these methods are globally accessible
    public void SetHighScore(int score)
    {
        highScore = highScore + score;
    }
    public int GetHighScore()
    {
        return highScore;
    }
}
