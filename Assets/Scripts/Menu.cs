using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator transition;
    
    public float transitionTime = 1f;

    // Menu Buttons
    public void StartGame() { LoadNextScene("Game");}
    public void InputProblem() { LoadNextScene("Problem");}
    public void Options() { LoadNextScene("Options");}
    public void Information() { LoadNextScene("Info");}
    public void PastScores() { LoadNextScene("Scores");}
    public void BackToTitle()
    {
        if (PauseMenu.GameIsPaused)
        {
            Time.timeScale = 1f;
            PauseMenu.GameIsPaused = false;
        }
        LoadNextScene("Title"); Debug.Log("button pressed");  
    }

    /// <summary>
    /// Responsible for loading scenes with the proper transition effect
    /// </summary>
    /// <param name="sceneName"></param>
    public void LoadNextScene(string sceneName)
    {
        StartCoroutine(LoadInScene(sceneName));
    }

    IEnumerator LoadInScene(string sceneName)
    {
        // Plays Transition Animation
        transition.SetTrigger("Start");

        //Waits
        yield return new WaitForSeconds(transitionTime);

        //Loads Scene
        SceneManager.LoadScene(sceneName);
    }
}
