using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
    {

    public void LoadLevel(string name)
        {
        Debug.Log("Level Load requested for: " + name);
        SceneManager.LoadScene(name);
        }

    public void StartRequest()
        {
            

        }

    public void QuitRequest()
        {
        print("Quit request in Level manager bro");
        Application.Quit();
        }

    public  void LoadNextLevel()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // loads the next level that is incremented in the build index menu
        }

        }
    
