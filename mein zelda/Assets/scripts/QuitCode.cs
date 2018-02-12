using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCode : MonoBehaviour
{
    //public int QuitLevel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
            Debug.Log("LevelQuit");
        }
    }
    

}
