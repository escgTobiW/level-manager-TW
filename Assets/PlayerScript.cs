using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int speed = 4;
    

    void Start()
    {
        LevelManager.instance.SetHighScore(10);

    }


    void Update()
    {
        if ((Input.GetKey("w")) || (Input.GetKey("a")) || (Input.GetKey("s")) || (Input.GetKey("d")))
        {

        

            if (Input.GetKey("w"))
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey("a"))
            {
                transform.Rotate(0, -0.2f, 0);
            }

            if (Input.GetKey("s"))
            {
                transform.position -= transform.forward * speed * Time.deltaTime;

            }

            if (Input.GetKey("d"))
            {
                transform.Rotate(0, 0.2f, 0);
            }

        }
    


    }

    //debug text output
    private void OnGUI()
    {
        //read variable from LevelManager singleton
        int score = LevelManager.instance.GetHighScore();

        string text = "High score: " + score;

        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();
    }


}
