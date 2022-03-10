using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Menu Buttons
    public void StartGame() {SceneManager.LoadScene("Game");}
    public void Options() {SceneManager.LoadScene("Options");}
    public void Information() { SceneManager.LoadScene("Info");}
    public void PastScores() { SceneManager.LoadScene("Scores");}
    public void BackToTitle() { SceneManager.LoadScene("Title");}

}
